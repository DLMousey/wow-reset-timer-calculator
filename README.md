# WoW Reset Timer Calculator
A small utility that displays the time difference between now and when the next daily + weekly reset is for a given region.

## Linux Installation (UNTESTED)
This should work _in theory_ but i've not tested it yet for a native installation on linux, run the following then copy the contents of `build/release/publish` into a `/usr/bin` directory of your choice, then add to path;
```
dotnet publish -c release --self-contained --runtime linux-x64 --framework netcoreapp3.1
```

**UNTESTED - I have not tried this**
PRs that add scripts for build + installation would be much appreciated though
