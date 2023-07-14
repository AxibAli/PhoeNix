using UnityEngine;
using System.Collections.Generic;
using System;
using System.Collections;

namespace RO
{
	public static class ROWords
	{
		public const string CONFIRM = "Confirm";
		public const string CANCEL = "Cancel";
		public const string RETRY = "Retry";
		public const string QUIT_GAME = "Quit";
		public const string DOWNLOAD_UPDATE = "Update";
		public const string GOTO = "Go";

		public const string DOWNLOADING = "Downloading";
		public const string UNZIPPING = "Extracting";
		public const string POOR_NET = "Poor network, please check~";
		public const string ERROR_NET = "Network connection exception\nPlease check your network settings and try again later!";
		public const string TRY_RECONNET = "Connecting to server";

		public const string UNKNOWN_ERROR = "Unknown error";

		public const string TRYING_FIX = "We’re working on this.(..•˘_˘•..)";


		public const string FIX_MODE_DESC = "Repair mode:\nThe resource will be re-decompressed and resource updates will be detected and downloaded.";
		public const string FIX = "Repair";


		public const string CHECKING_LOCAL_VERSION = "Checking the current version";
		public const string CHECKING_REMOTE_VERSION = "Checking for the latest version";
		public const string NEED_REINSTALL_NEW = "The client needs to update, there ";
		public const string HARDWARE_NOTENOUGH = "Installation requires {0}, capacity of device is insufficient, please adjust and try again";
		public const string UNZIPING_FILES_PROGRESS = "Extracting Resource Package {0} / {1}";
		public const string UNZIPING_PROGRESS = "Extracting... {0:N0}%";
		public const string UNZIPING_DONOT_LEAVE = "Patience. Game extracting - do not exit.";

		public const string ZIPFILE_VERIFYMD5_ERROR = "Extraction check failed\nPlease check the remaining space on the device, and try again";
		public const string ZIPFILE_BROKEN_ERROR = "The compressed file is corrupted, please reinstall the game.";
		public const string ZIPFILE_UNZIP_ERROR = "Decompression failed, please check remaining space and retry";
		public const string ZIPFILE_NOTFOUND_ERROR = "Cannot find the compressed file, please reinstall the game.";
		public const string ZIPFILE_DUPLICATE_UNZIPPING_ERROR = "Cannot execute current operation in decompression";
		public const string ZIPFILE_ZIPINFO_ERROR = "Failed to read the information of compressed file";
		public const string ZIPFILE_UNKNOWN_ERROR = "Decompression failed: unknown error";


		public const string NOWIFIENV_UPDATE_INFO = "Resource for updating, Size {0}, \n (automatically updated when connecting WiFi)";
		public const string DOWNLOAD_HASNOSPACE = "Installation package size {0}, capacity of mobile phone is insufficient, please adjust and try again";

		public const string DOWNLOAD_FILE_MD5_ERROR = "Hello, adventurer.\n\nError occurs on the downloaded resource bundle... \n\n";
		public const string DOWNLOAD_FILE_404_ERROR = "Hello, adventurer.\n\nCannot access the needed resource\nThe current version is {0}\n\nPlease wait up or contact game service";
		public const string DOWNLOAD_FILE_405_ERROR = "Hello, adventurer.\n\nError occurs. The current version is {0}\n\nPlease wait up or contact game service";
		public const string DOWNLOAD_FILE_DEFAULT_ERROR = "Hello, adventurer\n\nError occurs... Error Code:{0}\nMsg:{1} \n\nPlease wait up or contact game service";
		public const string DOWNLOAD_OVERTIME = "Download timeout, retrying";
		public const string DOWNLOAD_UPZIP_NOSPACE = "Capacity of mobile phone is insufficient, please adjust and try again";

		public const string CLICK_CONFIRM_REDOWNLOAD = "Tap <Confirm> to download again.(..•˘_˘•..)";

		public const string SERVER_VISIT_OVERTIME = "Access timed out.";
		public const string SERVER_VISIT_ERROR = "Access failed.";

		public const string FEED_BACK = "Hello, adventurer\n\n{0}\n\nYou can give your feedback through the Facebook Group. ";


	}
}
 // namespace RO