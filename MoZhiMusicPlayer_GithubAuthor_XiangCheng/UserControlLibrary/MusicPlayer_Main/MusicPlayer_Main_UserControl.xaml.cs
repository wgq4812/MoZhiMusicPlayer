﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MoZhiMusicPlayer_GithubAuthor_XiangCheng.UserControlLibrary.MusicPlayer_Main
{
    /// <summary>
    /// MusicPlayer_Main_UserControl.xaml 的交互逻辑
    /// </summary>
    public partial class MusicPlayer_Main_UserControl : UserControl
    {
        public MusicPlayer_Main_UserControl()
        {
            InitializeComponent();

            TextBox_SongName.TextAlignment = TextAlignment.Center;
            TextBox_SingerName.TextAlignment = TextAlignment.Center;
            TextBox_SongAlbumName.TextAlignment = TextAlignment.Center;

            Image_Song_Storyboard = Resources["Image_Song_Animation"] as Storyboard;
            ellipseGeometry = new EllipseGeometry();
            ellipseGeometry.RadiusX = 175;
            ellipseGeometry.RadiusY = 175;
            ellipseGeometry.Center = new Point(175,175);

            Storyboard_BeginMusic_Jukebox_Open = Resources["RotateTransform_BeginMusic_Jukebox_Open"] as Storyboard;
            Storyboard_BeginMusic_Jukebox_Open.Completed += Storyboard_BeginMusic_Jukebox_Open_Completed;
            Storyboard_BeginMusic_Jukebox_Close = Resources["RotateTransform_BeginMusic_Jukebox_Close"] as Storyboard;
            Storyboard_BeginMusic_Jukebox_Close.Completed += Storyboard_BeginMusic_Jukebox_Close_Completed;
            Storyboard_BeginMusic_Jukebox_Playing = Resources["RotateTransform_BeginMusic_Jukebox_Up_And_Down"] as Storyboard;
            
        }

        private void Storyboard_BeginMusic_Jukebox_Open_Completed(object? sender, EventArgs e)
        {
            Storyboard_BeginMusic_Jukebox_Open.Stop();
            RotateTransform_BeginMusic_Jukebox.Angle = 0;

            Storyboard_BeginMusic_Jukebox_Playing.Begin();
        }
        private void Storyboard_BeginMusic_Jukebox_Close_Completed(object? sender, EventArgs e)
        {
            Storyboard_BeginMusic_Jukebox_Open.Stop();
            RotateTransform_BeginMusic_Jukebox.Angle = -20;

            Storyboard_BeginMusic_Jukebox_Playing.Stop();
        }

       

        public Storyboard Storyboard_BeginMusic_Jukebox_Open = new Storyboard();
        public Storyboard Storyboard_BeginMusic_Jukebox_Close = new Storyboard();
        public Storyboard Storyboard_BeginMusic_Jukebox_Playing;

        public Storyboard Image_Song_Storyboard;
        public EllipseGeometry ellipseGeometry;
        public int model_Song_Album;
        private void Image_Song_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*if(model_Song_Album == 0)//圆形图片框+旋转动画
            {
                Image_Song.Clip = ellipseGeometry;
                Image_Song_Storyboard.Begin();

                model_Song_Album = 1;
            }
            else if(model_Song_Album == 1)//图片消失
            {
                Image_Song_Storyboard.Stop();
                Image_Song.Clip = null;

                Panel_Image.Visibility = Visibility.Hidden;

                model_Song_Album = 2;
            }
            else//方形图片框
            {
                Panel_Image.Visibility = Visibility.Visible;
                
                model_Song_Album = 0;
            }*/
        }
    }
}
