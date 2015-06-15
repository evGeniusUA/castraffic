  1. Install Mercurial for Windows, TortoiseHg: http://tortoisehg.bitbucket.org/
  1. Install Mercurial plugin for Visual Studio, VisualHg: http://sharesource.org/project/visualhg/
  1. Create a directory for your project-files (eg. Documents/castraffic).
  1. Open directory with Windows Explorer, Right-Click and start TortoiseHg -> Clone, Alter source-path to project (eg. https://castraffic.googlecode.com/hg/). Clone.
  1. Make sure you got a .hgignore file in your project directory.
  1. Open file hgrc in the .hg directory with any text-editor. Insert:
```
[paths]
default = https://myGoogleUsername:myGoogleCodePassword@castraffic.googlecode.com/hg/

[ui]
username = Myname MyFamilyName <myEmail@gmail.com>

[tortoisehg]
postpull = update
```
  1. Start Visual Studio. Clich Tools -> Options -> Source Control. Choose VisualHG
  1. Open the cloned Visual Studio project.

You should now be able to use Mercurial in Visual Studio (by right-clicking in the Soulution Explorer). Upload/Download with HG Synchronize. Remember to allways pull before pushing. Remember to HG Commit before pushing changes (please write a few sentences about the changes you've done).