from tkinter import *
from tkinter import filedialog
from watchdog.observers import Observer
from watchdog.events import PatternMatchingEventHandler
import os
import glob
import pandas as pd

class Watchdog(PatternMatchingEventHandler, Observer):
    def __init__(self, path='.', patterns='*', logfunc=print, file_extensions=print):
        PatternMatchingEventHandler.__init__(self, patterns)
        Observer.__init__(self)
        self.schedule(self, path=path, recursive=False)
        self.log = logfunc
        self.check_extension = file_extensions

    def on_created(self, event):
        # This function is called when a file is created
        self.log(f"{event.src_path} has been created!")
        self.check_extension()

    def on_moved(self, event):
        # This function is called when a file is moved    
        self.log(f"Moved {event.src_path} to {event.dest_path}")

class dev_test:           
    def __init__(self):
        self.watchdog = None
        self.watch_path = '.'
        self.root = Tk()
        self.root.title("Dev Test")
        self.messagebox = Text(width=80, height=10)
        self.messagebox.pack()
        frm = Frame(self.root)
        Button(frm, text='Select folder', command=self.select_path).pack(side=LEFT)
        frm.pack(fill=X, expand=1)
        self.root.protocol("WM_DELETE_WINDOW", lambda: on_closing(self))
        self.root.mainloop()

    def start_watchdog(self):
        if self.watchdog is None:
            self.watchdog = Watchdog(path=self.watch_path, logfunc=self.log, file_extensions=self.check_files_extension)
            self.watchdog.start()
            self.check_files_extension()

    def select_path(self):
        path = filedialog.askdirectory()
        if path:
            self.watch_path = path
            self.log(f'Selected path: {path}')
            self.start_watchdog()

    def log(self, message):
        self.messagebox.insert(END, f'{message}\n')
        self.messagebox.see(END)
    
    def check_files_extension(self):
        self.check_folder()
        for file in os.listdir(self.watch_path):
            if(file != "desktop.ini"):  # Ignore desktop.ini                
                if(file.endswith('.xls') and os.path.isfile(self.watch_path + '/' + file)): #Check if file is an excel file and if it is a file
                    self.merge_files(file)
                    self.log(f'{file} moved to Processed')
                    os.remove(os.path.join(os.sep, self.watch_path, file))
                elif(os.path.isfile(self.watch_path + '/' + file)):
                    os.replace(os.path.join(os.sep, self.watch_path, file), os.path.join(os.sep, self.watch_path + "/Not applicable/" + file))
                    self.log(f'{file} moved to Not applicable')
  
    def check_folder(self):
        if not os.path.exists(self.watch_path + '/Processed'):
            os.mkdir(self.watch_path + '/Processed')
        if not os.path.exists(self.watch_path + '/Not applicable'):
            os.mkdir(self.watch_path + '/Not applicable')
  
    def merge_files(self, excl_file):
        df_total = pd.DataFrame()
        excel_file = pd.ExcelFile(self.watch_path +'/' + excl_file)
        sheets = excel_file.sheet_names
        for sheet in sheets: # loop through sheets inside an Excel file
            df = excel_file.parse(sheet_name = sheet)
            df_total = df_total.append(df)
        df_total.to_excel(self.watch_path + '/Processed/combined_file_' + excl_file)
                   
def on_closing(self=None):
    stop_watchdog(self)
    self.root.destroy()
        
def stop_watchdog(self=None):
    if self.watchdog:
        self.watchdog.stop()
        self.watchdog = NONE

if __name__ == '__main__':
    dev_test()