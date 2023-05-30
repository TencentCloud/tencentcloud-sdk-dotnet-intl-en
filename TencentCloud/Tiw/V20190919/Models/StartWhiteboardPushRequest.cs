/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartWhiteboardPushRequest : AbstractModel
    {
        
        /// <summary>
        /// SdkAppId of the whiteboard application.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Room ID of the whiteboard push task. Valid range: (1,4294967295).
        /// 
        /// 1. By default, the whiteboard push task uses the RoomId string as the GroupID of the IM group. For example, if the RoomId string is 1234, the GroupID of the IM group is also 1234. Message synchronization requires joining a group. Make sure that an IM group is created before the push starts. Otherwise, the push fails.
        /// 2. If neither TRTCRoomId nor TRTCRoomIdStr is specified, the value of RoomId is used as the Tencent Real-Time Communication (TRTC) room ID for the whiteboard push task.
        /// </summary>
        [JsonProperty("RoomId")]
        public long? RoomId{ get; set; }

        /// <summary>
        /// User ID used by the whiteboard push service for entering the whiteboard room. If `IMAuthParam`and `TRTCAuthParam` are not specified, this user ID is used for operations such as logging in to the IM application, joining an IM group, and entering the room for TRTC whiteboard push.
        /// The ID cannot exceed 60 bytes in length and must be an unused ID. The whiteboard push service uses the user ID to enter the room for whiteboard audio/video push. If this ID is already used in another scenario, the other scenario and whiteboard push service will conflict, affecting the pushing operation.
        /// </summary>
        [JsonProperty("PushUserId")]
        public string PushUserId{ get; set; }

        /// <summary>
        /// User's IM signature corresponding to the PushUserId.
        /// </summary>
        [JsonProperty("PushUserSig")]
        public string PushUserSig{ get; set; }

        /// <summary>
        /// Whiteboard parameters, such as the width, height, and background color of the whiteboard.
        /// </summary>
        [JsonProperty("Whiteboard")]
        public Whiteboard Whiteboard{ get; set; }

        /// <summary>
        /// Whiteboard push timeout. Unit: seconds. Valid range: [300,259200]. Default value: 1800.
        /// 
        /// If no operation is performed on the whiteboard for the specified period of time, the whiteboard push service automatically stops whiteboard push.
        /// </summary>
        [JsonProperty("AutoStopTimeout")]
        public long? AutoStopTimeout{ get; set; }

        /// <summary>
        /// Specifies whether to synchronize operations on the primary whiteboard push task to the backup task.
        /// </summary>
        [JsonProperty("AutoManageBackup")]
        public bool? AutoManageBackup{ get; set; }

        /// <summary>
        /// Parameters of the backup whiteboard push task.
        /// 
        /// After the backup parameters are specified, the whiteboard push service adds a relayed video stream. That is, there are two video streams on the whiteboard in the same room.
        /// </summary>
        [JsonProperty("Backup")]
        public WhiteboardPushBackupParam Backup{ get; set; }

        /// <summary>
        /// Advanced permission control parameter in TRTC. If the advanced permission control feature is enabled in TRTC, this parameter is required.
        /// </summary>
        [JsonProperty("PrivateMapKey")]
        public string PrivateMapKey{ get; set; }

        /// <summary>
        /// Frame rate of the whiteboard push video. Valid range: [0,30]. Default value: 20. Unit: fps.
        /// </summary>
        [JsonProperty("VideoFPS")]
        public long? VideoFPS{ get; set; }

        /// <summary>
        /// Whiteboard push bitrate. Valid range: [0,2000]. Default value: 1200. Unit: kbps.
        /// 
        /// The bitrate specified here is a reference value. During actual push, a dynamic bitrate is used. The actual bitrate does not remain the specified value but rather fluctuates around it.
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public long? VideoBitrate{ get; set; }

        /// <summary>
        /// Specifies whether to automatically record the whiteboard push when the recording mode in TRTC is set to `SubscribeStreamUserIds`.
        /// 
        /// Default value: `false`. If you need to enable automatic whiteboard push recording, set this parameter to `true`.
        /// 
        /// If the recording mode in TRTC is set to `Global Auto Recording`, ignore this parameter.
        /// </summary>
        [JsonProperty("AutoRecord")]
        public bool? AutoRecord{ get; set; }

        /// <summary>
        /// ID of the whiteboard push recording. The ID is filled in the `userdefinerecordid` parameter in the callback message after cloud recording is complete in TRTC, helping you identify the recording callback and locate the video file in VOD media resource management.
        /// 
        /// The value can be up to 64 bytes in length and contain letters (a-z and A-Z), digits (0-9), underscores (_), and hyphens (-).
        /// 
        /// After this parameter is set, automatic whiteboard push recording is enabled regardless of the value of the `AutoRecord` parameter.
        /// 
        /// Default RecordId generation rule:
        /// urlencode(SdkAppID_RoomID_PushUserID)
        /// 
        /// Example:
        /// SdkAppID = 12345678，RoomID = 12345，PushUserID = push_user_1
        /// Therefore: RecordId = 12345678_12345_push_user_1
        /// </summary>
        [JsonProperty("UserDefinedRecordId")]
        public string UserDefinedRecordId{ get; set; }

        /// <summary>
        /// Specifies whether to enable automatic relay whiteboard push when the relay push mode in TRTC is set to `SubscribeRelayUserIds`.
        /// 
        /// Default value: `false`. If you need to enable automatic relay whiteboard push, set this parameter to `true`.
        /// 
        /// If the recording mode in TRTC is set to `Global Auto Relay`, ignore this parameter.
        /// </summary>
        [JsonProperty("AutoPublish")]
        public bool? AutoPublish{ get; set; }

        /// <summary>
        /// Stream ID used by TRTC for relay whiteboard push. With this ID, you can stream the user’s audio/video by using the domain name and standard streaming solution (FLV or HLS) in TRTC.
        /// 
        /// The value can be up to 64 bytes in length and contain letters (a-z and A-Z), digits (0-9), underscores (_), and hyphens (-).
        /// 
        /// After this parameter is set, automatic relay whiteboard push is enabled regardless of the value of the `AutoPublish` parameter.
        /// 
        /// Default StreamID generation rule:
        /// urlencode(SdkAppID_RoomID_PushUserID_main)
        /// 
        /// Example:
        /// SdkAppID = 12345678，RoomID = 12345，PushUserID = push_user_1
        /// Therefore, StreamID = 12345678_12345_push_user_1_main
        /// </summary>
        [JsonProperty("UserDefinedStreamId")]
        public string UserDefinedStreamId{ get; set; }

        /// <summary>
        /// Internal parameter. You can ignore this parameter.
        /// </summary>
        [JsonProperty("ExtraData")]
        public string ExtraData{ get; set; }

        /// <summary>
        /// TRTC room ID of the numeric type. Valid range: (1,4294967295).
        /// 
        /// If RoomId and TRTCRoomId are both specified, the value of TRTCRoomId takes priority as the room ID for TRTC whiteboard push.
        /// 
        /// If the TRTCRoomIdStr parameter is specified, this parameter is ignored.
        /// </summary>
        [JsonProperty("TRTCRoomId")]
        public long? TRTCRoomId{ get; set; }

        /// <summary>
        /// TRTC room ID of the string type.
        /// 
        /// If TRTCRoomIdStr is specified, its value takes priority as the room ID for TRTC whiteboard push.
        /// </summary>
        [JsonProperty("TRTCRoomIdStr")]
        public string TRTCRoomIdStr{ get; set; }

        /// <summary>
        /// IM authentication parameters.
        /// If the ID of the IM application used by whiteboard messages is different from SdkAppId of the whiteboard application, specify this parameter to provide authentication information of the IM application.
        /// 
        /// If this parameter is specified, the whiteboard push service preferably uses the SdkAppId value in this parameter as the transmission channel for whiteboard messages. If this parameter is left empty, the SdkAppId value in the common parameters is used.
        /// </summary>
        [JsonProperty("IMAuthParam")]
        public AuthParam IMAuthParam{ get; set; }

        /// <summary>
        /// TRTC authentication parameters, used for room entrance authentication for TRTC push.
        /// If the ID of the TRTC application to which the target TRTC room belongs is different from SdkAppId of the whiteboard application, specify this parameter to provide authentication information of the TRTC application.
        /// 
        /// If this parameter is specified, the whiteboard push service preferably uses the SdkAppId value in this parameter as the ID of the target TRTC application. If this parameter is left empty, the SdkAppId value in the common parameters is used.
        /// </summary>
        [JsonProperty("TRTCAuthParam")]
        public AuthParam TRTCAuthParam{ get; set; }

        /// <summary>
        /// This parameter is available only to users in the allowlist for trial.
        /// 
        /// TRTC room entrance mode for whiteboard push. Default value: `TRTCAppSceneVideoCall`.
        /// 
        /// `TRTCAppSceneVideoCall`: This scenario is most suitable when there are two or more people on a video call. The internal encoders and network protocols are optimized for video smoothness to reduce call latency and lagging.
        /// `TRTCAppSceneLIVE`: This scenario is most suitable when there is only one person speaking or performing for an online audience, and occasionally multiple people interact with one another through video. The internal encoders and network protocols are optimized for performance and compatibility to deliver better performance and video clarity.
        /// </summary>
        [JsonProperty("TRTCEnterRoomMode")]
        public string TRTCEnterRoomMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "PushUserId", this.PushUserId);
            this.SetParamSimple(map, prefix + "PushUserSig", this.PushUserSig);
            this.SetParamObj(map, prefix + "Whiteboard.", this.Whiteboard);
            this.SetParamSimple(map, prefix + "AutoStopTimeout", this.AutoStopTimeout);
            this.SetParamSimple(map, prefix + "AutoManageBackup", this.AutoManageBackup);
            this.SetParamObj(map, prefix + "Backup.", this.Backup);
            this.SetParamSimple(map, prefix + "PrivateMapKey", this.PrivateMapKey);
            this.SetParamSimple(map, prefix + "VideoFPS", this.VideoFPS);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "AutoRecord", this.AutoRecord);
            this.SetParamSimple(map, prefix + "UserDefinedRecordId", this.UserDefinedRecordId);
            this.SetParamSimple(map, prefix + "AutoPublish", this.AutoPublish);
            this.SetParamSimple(map, prefix + "UserDefinedStreamId", this.UserDefinedStreamId);
            this.SetParamSimple(map, prefix + "ExtraData", this.ExtraData);
            this.SetParamSimple(map, prefix + "TRTCRoomId", this.TRTCRoomId);
            this.SetParamSimple(map, prefix + "TRTCRoomIdStr", this.TRTCRoomIdStr);
            this.SetParamObj(map, prefix + "IMAuthParam.", this.IMAuthParam);
            this.SetParamObj(map, prefix + "TRTCAuthParam.", this.TRTCAuthParam);
            this.SetParamSimple(map, prefix + "TRTCEnterRoomMode", this.TRTCEnterRoomMode);
        }
    }
}

