@echo off
C:
IF NOT EXIST %UserProfile%\Desktop\Lessons GOTO INIT
echo Repository exists. Updating.
CD %UserProfile%\Desktop\Lessons
git pull
GOTO endproc

:INIT
echo Initializing Repository
CD %UserProfile%\Desktop\
git clone https://github.com/EDCC-GDC/Lessons.git

:endproc