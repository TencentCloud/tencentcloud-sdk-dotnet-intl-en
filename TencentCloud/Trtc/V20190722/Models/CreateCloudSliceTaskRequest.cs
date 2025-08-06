/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCloudSliceTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// [SdkAppId](https://www.tencentcloud.comom/document/product/647/46351?from_cn_redirect=1#sdkappid) of TRTC, which is the same as the SdkAppId corresponding to the TRTC room.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// [RoomId](https://www.tencentcloud.comom/document/product/647/46351?from_cn_redirect=1#roomid) of TRTC, which is the RoomId corresponding to the TRTC room.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// Chatbot's UserId, which is used to enter the room and initiate a slicing task. [*note] This UserId should not be duplicated with the UserIds of the current anchors or audience members in the room. If multiple slicing tasks are initiated in one room, the chatbot's UserId should also be unique; otherwise, the previous slicing task is interrupted. It is recommended to include the room ID as part of the UserId, ensuring that the chatbot's UserId is unique in the room.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Signature verification corresponding to the chatbot's UserId, namely, the UserId and UserSig serve as the login password for the chatbot to enter the room. For specific calculation methods, see TRTC solution for calculating UserSig.
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// Control parameters for cloud slicing.
        /// </summary>
        [JsonProperty("SliceParams")]
        public SliceParams SliceParams{ get; set; }

        /// <summary>
        /// Parameters for uploading cloud slicing files to the cloud storage.
        /// </summary>
        [JsonProperty("SliceStorageParams")]
        public SliceStorageParams SliceStorageParams{ get; set; }

        /// <summary>
        /// Type of the TRTC room number. [*Note] It should be the same as the type of the RoomId corresponding to the recording room. 0: string type; 1: 32-bit integer type (default value). Example value: 1.
        /// </summary>
        [JsonProperty("RoomIdType")]
        public ulong? RoomIdType{ get; set; }

        /// <summary>
        /// Validity period for calling the API, which starts upon successful initiation of recording and obtaining the task ID. After the timeout, APIs such as querying, updating, or stopping cannot be called, but the recording task is not stopped. The unit of the parameter is hours, with a default value of 72 hours (3 days). The maximum value is 720 hours (30 days), while the minimum value is 6 hours. For example, if this parameter is not specified, the validity period for calling the querying, updating, and stopping recording APIs is 72 hours upon the successful start of recording. Example value: 24.
        /// </summary>
        [JsonProperty("ResourceExpiredHour")]
        public ulong? ResourceExpiredHour{ get; set; }

        /// <summary>
        /// TRTC room permission encryption string, which is required only when advanced permission control is enabled in the TRTC console. After enabling, the TRTC backend service system verifies a "permission ticket" called [PrivateMapKey], which contains an encrypted RoomId and an encrypted "permission bit list". Since the PrivateMapKey includes the RoomId, the specified room cannot be entered if only UserSig is provided and PrivateMapKey is not provided. Example value: eJw1jcEKgkAURX9FZlvY****fL9rfNX4_.
        /// </summary>
        [JsonProperty("PrivateMapKey")]
        public string PrivateMapKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamObj(map, prefix + "SliceParams.", this.SliceParams);
            this.SetParamObj(map, prefix + "SliceStorageParams.", this.SliceStorageParams);
            this.SetParamSimple(map, prefix + "RoomIdType", this.RoomIdType);
            this.SetParamSimple(map, prefix + "ResourceExpiredHour", this.ResourceExpiredHour);
            this.SetParamSimple(map, prefix + "PrivateMapKey", this.PrivateMapKey);
        }
    }
}

