# DFR Content Host Application for Windows

This is a modified Host Application for Macbook pro 2019 16 inch based on [imbushuo](https://github.com/imbushuo)'s [DFRContentHost](https://github.com/imbushuo/DFRContentHost)

What have changed:
- Change resolution from 2170 * 60 to 2008 * 60 to make it work (the touch bar is shorter than the old model, 2008 is the maximum support width)
- Remove virtual esc button (There's exist esc key on the new macbooks pro)
- Specific font for support language like Japanese and Chinese
- Zero width in columnDefinition to prevent the f12 key from disappear out of touch bar after removing the esc key
- Add Margin in both MediaTitle and MediaArtist to keep the space between MediaThumbnail and MediaTitle/MediaArtist
- Add limit to prevent contents beyond from MediaTitle

=---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------=
# Original readme document

This application implements the user-mode host application for [DFRDisplayKm](https://github.com/imbushuo/DFRDisplayKm).

![High Level Overview Topology](docs/DFR%20High%20Level%20Topology.jpg)

# License

Copyright (c) Bingxing Wang. All rights reserved.

Licensed under the [MIT License](https://github.com/imbushuo/DFRContentHost/blob/master/LICENSE.txt)
