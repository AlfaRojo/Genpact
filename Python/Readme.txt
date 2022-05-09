*Dev test by Kevin Ramírez

Built on python with TKinker
.exe file can be found on /dist

I use watchdog for the watcher on the specific folder, each time one is created with the extension .xls
will check for "Processed" and "Not applicable" exist, other wise, will be created. 
None folders are afected. Once found a file with the requiere extension, will create a DataFrame(with pandas)
and will concat each sheet on it, and merge into single sheet. The original is deleted, and the new one is created on 
/Processed with the name "combined_file_<prev_name.xls>"

For any file diferent of the extension .xls and is file, will be moved to "Not applicable"