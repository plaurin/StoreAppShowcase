using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace App1.ViewModels
{
    class AppBarButtonsViewModel
    {
        public IList<Button> StylesButton
        {
            get
            {
                var result = new List<Button>();

                foreach (var styleName in Styles)
                {
                    var button = new Button();
                    var style = Application.Current.Resources[styleName] as Style;

                    button.Style = style;
                    result.Add(button);
                }

                return result;
            }
        }

        public IList<string> Styles
        {
            get
            {
                return new[]
                {
                    "SkipBackAppBarButtonStyle", "SkipAheadAppBarButtonStyle", "PlayAppBarButtonStyle", 
                    "PauseAppBarButtonStyle", "EditAppBarButtonStyle", "SaveAppBarButtonStyle", "DeleteAppBarButtonStyle", 
                    "DiscardAppBarButtonStyle", "RemoveAppBarButtonStyle", "AddAppBarButtonStyle", "NoAppBarButtonStyle", 
                    "YesAppBarButtonStyle", "MoreAppBarButtonStyle", "RedoAppBarButtonStyle", "UndoAppBarButtonStyle", 
                    "HomeAppBarButtonStyle", "OutAppBarButtonStyle", "NextAppBarButtonStyle", "PreviousAppBarButtonStyle", 
                    "FavoriteAppBarButtonStyle", "PhotoAppBarButtonStyle", "SettingsAppBarButtonStyle", 
                    "VideoAppBarButtonStyle", "RefreshAppBarButtonStyle", "DownloadAppBarButtonStyle", "MailAppBarButtonStyle",
                    "SearchAppBarButtonStyle", "HelpAppBarButtonStyle", "UploadAppBarButtonStyle", "EmojiAppBarButtonStyle",
                    "TwoPageAppBarButtonStyle", "LeaveChatAppBarButtonStyle", "MailForwardAppBarButtonStyle", 
                    "ClockAppBarButtonStyle", "SendAppBarButtonStyle", "CropAppBarButtonStyle", "RotateCameraAppBarButtonStyle",
                    "PeopleAppBarButtonStyle", "ClosePaneAppBarButtonStyle", "OpenPaneAppBarButtonStyle", 
                    "WorldAppBarButtonStyle", "FlagAppBarButtonStyle", "PreviewLinkAppBarButtonStyle", 
                    "GlobeAppBarButtonStyle", "TrimAppBarButtonStyle", "AttachCameraAppBarButtonStyle", 
                    "ZoomInAppBarButtonStyle", "BookmarksAppBarButtonStyle", "DocumentAppBarButtonStyle", 
                    "ProtectedDocumentAppBarButtonStyle", "PageAppBarButtonStyle", "BulletsAppBarButtonStyle", 
                    "CommentAppBarButtonStyle", "Mail2AppBarButtonStyle", "ContactInfoAppBarButtonStyle", 
                    "HangUpAppBarButtonStyle", "ViewAllAppBarButtonStyle", "MapPinAppBarButtonStyle", "PhoneAppBarButtonStyle",
                    "VideoChatAppBarButtonStyle", "SwitchAppBarButtonStyle", "ContactAppBarButtonStyle", 
                    "RenameAppBarButtonStyle", "PinAppBarButtonStyle", "MusicInfoAppBarButtonStyle", "GoAppBarButtonStyle",
                    "KeyboardAppBarButtonStyle", "DockLeftAppBarButtonStyle", "DockRightAppBarButtonStyle", 
                    "DockBottomAppBarButtonStyle", "RemoteAppBarButtonStyle", "SyncAppBarButtonStyle", 
                    "RotateAppBarButtonStyle", "ShuffleAppBarButtonStyle", "ListAppBarButtonStyle", 
                    "ShopAppBarButtonStyle", "SelectAllAppBarButtonStyle", "OrientationAppBarButtonStyle", 
                    "ImportAppBarButtonStyle", "ImportAllAppBarButtonStyle", "BrowsePhotosAppBarButtonStyle", 
                    "WebcamAppBarButtonStyle", "PicturesAppBarButtonStyle", "SaveLocalAppBarButtonStyle", 
                    "CaptionAppBarButtonStyle", "StopAppBarButtonStyle", "ShowResultsAppBarButtonStyle", 
                    "VolumeAppBarButtonStyle", "RepairAppBarButtonStyle", "MessageAppBarButtonStyle", "Page2AppBarButtonStyle",
                    "CalendarDayAppBarButtonStyle", "CalendarWeekAppBarButtonStyle", "CalendarAppBarButtonStyle", 
                    "CharactersAppBarButtonStyle", "MailReplyAllAppBarButtonStyle", "ReadAppBarButtonStyle", 
                    "LinkAppBarButtonStyle", "AccountsAppBarButtonStyle", "ShowBccAppBarButtonStyle", 
                    "HideBccAppBarButtonStyle", "CutAppBarButtonStyle", "AttachAppBarButtonStyle", "PasteAppBarButtonStyle", 
                    "FilterAppBarButtonStyle", "CopyAppBarButtonStyle", "Emoji2AppBarButtonStyle", "ImportantAppBarButtonStyle",
                    "MailReplyAppBarButtonStyle", "SlideShowAppBarButtonStyle", "SortAppBarButtonStyle", 
                    "ManageAppBarButtonStyle", "AllAppsAppBarButtonStyle", "DisconnectDriveAppBarButtonStyle", 
                    "MapDriveAppBarButtonStyle", "NewWindowAppBarButtonStyle", "OpenWithAppBarButtonStyle", 
                    "ContactPresenceAppBarButtonStyle", "PriorityAppBarButtonStyle", "UploadSkyDriveAppBarButtonStyle",
                    "GoToTodayAppBarButtonStyle", "FontAppBarButtonStyle", "FontColorAppBarButtonStyle", 
                    "Contact2AppBarButtonStyle", "FolderppBarButtonStyle", "AudioAppBarButtonStyle", 
                    "PlaceholderAppBarButtonStyle", "ViewAppBarButtonStyle", "SetLockScreenAppBarButtonStyle", 
                    "SetTitleAppBarButtonStyle", "CcAppBarButtonStyle", "StopSlideShowAppBarButtonStyle", 
                    "PermissionsAppBarButtonStyle", "HighlightAppBarButtonStyle", "DisableUpdatesAppBarButtonStyle", 
                    "UnfavoriteAppBarButtonStyle", "UnPinAppBarButtonStyle", "OpenLocalAppBarButtonStyle", 
                    "MuteAppBarButtonStyle", "ItalicAppBarButtonStyle", "UnderlineAppBarButtonStyle", "BoldAppBarButtonStyle", 
                    "MoveToFolderAppBarButtonStyle", "LikeDislikeAppBarButtonStyle", "DislikeAppBarButtonStyle", 
                    "LikeAppBarButtonStyle", "AlignRightAppBarButtonStyle", "AlignCenterAppBarButtonStyle",
                    "AlignLeftAppBarButtonStyle", "ZoomAppBarButtonStyle", "ZoomOutAppBarButtonStyle", 
                    "OpenFileAppBarButtonStyle", "OtherUserAppBarButtonStyle", "AdminAppBarButtonStyle", 
                    "StreetAppBarButtonStyle", "MapAppBarButtonStyle", "ClearSelectionAppBarButtonStyle", 
                    "FontDecreaseAppBarButtonStyle", "FontIncreaseAppBarButtonStyle", "FontSizeAppBarButtonStyle", 
                    "CellphoneAppBarButtonStyle", "ReshareAppBarButtonStyle", "TagAppBarButtonStyle", 
                    "RepeatOneAppBarButtonStyle", "RepeatAllAppBarButtonStyle", "OutlineStarAppBarButtonStyle", 
                    "SolidStarAppBarButtonStyle", "CalculatorAppBarButtonStyle", "DirectionsAppBarButtonStyle", 
                    "TargetAppBarButtonStyle", "LibraryAppBarButtonStyle", "PhonebookAppBarButtonStyle", 
                    "MemoAppBarButtonStyle", "MicrophoneAppBarButtonStyle", "PostUpdateAppBarButtonStyle", 
                    "BackToWindowAppBarButtonStyle", "FullScreenAppBarButtonStyle", "NewFolderAppBarButtonStyle", 
                    "CalendarReplyAppBarButtonStyle", "UnsyncFolderAppBarButtonStyle", "ReportHackedAppBarButtonStyle", 
                    "SyncFolderAppBarButtonStyle", "BlockContactAppBarButtonStyle", "SwitchAppsAppBarButtonStyle", 
                    "AddFriendAppBarButtonStyle", "TouchPointerAppBarButtonStyle", "GoToStartAppBarButtonStyle", 
                    "ZeroBarsAppBarButtonStyle", "OneBarAppBarButtonStyle", "TwoBarsAppBarButtonStyle", 
                    "ThreeBarsAppBarButtonStyle", "FourBarsAppBarButtonStyle"
                };
            }
        }
    }
}
