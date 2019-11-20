@echo off
paket restore
packages\FAKE\tools\FAKE.exe build.fsx %*
