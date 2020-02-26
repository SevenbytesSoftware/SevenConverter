# FREE VIDEO AND AUDIO CONVERTER - SEVEN CONVERTER
 
 ![SevenConverter](https://raw.githubusercontent.com/SevenbytesSoftware/SevenConverter/master/assets/SevenConverter.PNG)

**Seven Converter** - simple tool to convert media files to various formats. The program is distributed for free under the Apache 2.0 license. It uses an open source libraries FFMPEG (build by http://ffmpeg.zeranoe.com/). The main goal of the program was to create an easy-to-use interface over FFMPEG console utilities with a minimum of additional settings. The project used icons from the Open Icon Library.

## Features

- Sequential processing of multiple files.
- Joining several files into one (videos must be with the same resolution).
- Automatically determine the number of threads to encode based on the number of CPU cores.
- Automatically rename a file when matching names.
- Getting file information.
- Play one or more files.

## Video conversion

- Source Video File Formats: *.avi; *.mov; *.mkv; *.mpg; *.3gp; *.flv; *.vob; *.mp4; *.ts; *.m2ts.
- Convert to Video Formats: AVI, MOV, MKV, MP4.
- Video Codecs: H.264, MJPEG, XVID, MPEG2.
- Adaptive video bitrate.
- Ability to manually adjust the video bitrate (to reduce the size of the output file).
- Audio Codecs: MP3, AC3, PCM.
- Change the bitrate and sample rate of audio.
- Ability to use source video and audio streams without transcoding.
- Video without sound.
- Change the aspect of the video.
- Scaling video by the number of lines (width is calculated automatically).
- The maximum quality parameters are used when using the MJPEG codec for maximum bitrate (according to the requirements of video banks).
- Subtitle Support.
- Frame rate change.
- Change the type of scan - progressive / interlaced.
- Selects a specific or all source audio tracks.

## Audio conversion

- Source Audio File Formats: *.mp3; *.m4a; *.wav; *.flac; *.ogg; *.ape; *.amr; *.acc.
- Convert to audio formats: MP3, OGG Vorbis, FLAC, WAV.
- Change the bitrate and sample rate of audio.

## Requirements

- Microsoft Windows x64 operating system.
- Installed Microsoft .NET Framework 4.0.

## Download and Install

1. You can download the archive with the program from [latest builds](https://github.com/SevenbytesSoftware/SevenConverter/releases/latest).
2. Unzip files from the zip archive to any convenient folder.
3. Run file `SevenConverter.exe`.

## Using Converter

1. Choose the type of media files - video or audio.
2. Add source files by selecting a menu item in the menu that pops up with the right mouse button or dragging the necessary files from the explorer.
3. Select the destination folder for new files or leave the proposed one - the source files folder is used by default (if the file names match, the new files will be automatically assigned a numerical index).
4. Select format settings, codecs and their additional parameters.
5. Press the coding start button.

## Custom Build

1. First of all, you need to download or clone the source from the link https://github.com/SevenbytesSoftware/SevenConverter
2. To compile you need to open the file `SevenConverter\Seven Converter.sln` in the Visual Studio 2019 and run the Build.
3. Then you need to download the latest build of `FFMPEG` from site http://ffmpeg.zeranoe.com/builds/ and put the files in the `ffmpeg` subfolder next to the file obtained in the previous step `SevenConverter.exe`.
4. The program checks the presence of `FFMPEG` at startup and throws an error if they are absent.

## Localization

Localization resource files is located in the `Properties` and `Forms`.
Files with interface translation after compiling the program are placed in subfolders with a two-letter language designation.
The language of the program interface is determined automatically depending on the language of the operating system.

## Copyright, License

SevenConverter is copyright (c) 2019 SevenBytes Software.

Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at

https://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.

You may also see the license in the file [LICENSE](https://github.com/SevenbytesSoftware/SevenConverter/blob/master/LICENSE) in the source distribution.

## Contact

You can contact the developers using the [Issues](https://github.com/SevenbytesSoftware/SevenConverter/issues).
