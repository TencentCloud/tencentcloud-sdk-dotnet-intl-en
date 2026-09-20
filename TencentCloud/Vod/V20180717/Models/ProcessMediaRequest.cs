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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProcessMediaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Media file ID, the globally unique identifier of the file on VOD, assigned by the VOD backend after successful upload. You can obtain this field in <a href="/document/product/266/7830">video upload completion event notification</a> or the <a href="https://console.cloud.tencent.com/vod/media">VOD console</a>.<br>You must provide either FileId or MediaStoragePath.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Storage path of the media.<br>Only sub-apps in <a href="https://www.tencentcloud.com/document/product/266/126825?from_cn_redirect=1">FileID + Path mode</a> can initiate tasks through MediaStoragePath.<br>Either FileId or MediaStoragePath must be provided.</p>
        /// </summary>
        [JsonProperty("MediaStoragePath")]
        public string MediaStoragePath{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services from December 25, 2023, if they access resources in on-demand applications (whether the default application or a newly created application), this field must be filled in as the app ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Video processing type task parameters.</p>
        /// </summary>
        [JsonProperty("MediaProcessTask")]
        public MediaProcessTaskInput MediaProcessTask{ get; set; }

        /// <summary>
        /// <p>Audio and video content review type task parameters *.<br><font color="red">* Not recommended for use</font>. Recommended for use: <a href="https://www.tencentcloud.com/document/api/266/80283?from_cn_redirect=1">Audio/Video Moderation (ReviewAudioVideo)</a> or <a href="https://www.tencentcloud.com/document/api/266/73217?from_cn_redirect=1">Image Moderation (ReviewImage)</a>.</p>
        /// </summary>
        [JsonProperty("AiContentReviewTask")]
        public AiContentReviewTaskInput AiContentReviewTask{ get; set; }

        /// <summary>
        /// <p>Parameters for the audio and video content analysis task.</p>
        /// </summary>
        [JsonProperty("AiAnalysisTask")]
        public AiAnalysisTaskInput AiAnalysisTask{ get; set; }

        /// <summary>
        /// <p>Audio/video content recognition type task parameter.</p>
        /// </summary>
        [JsonProperty("AiRecognitionTask")]
        public AiRecognitionTaskInput AiRecognitionTask{ get; set; }

        /// <summary>
        /// <p>Priority of the task flow. The higher the value, the higher the priority. The value range is from -10 to 10. If this is not specified, the default value is 0.</p>
        /// </summary>
        [JsonProperty("TasksPriority")]
        public long? TasksPriority{ get; set; }

        /// <summary>
        /// <p>Task flow status change notification mode. Valid values are Finish, Change, and None. If this is not specified, the default value is Finish.</p>
        /// </summary>
        [JsonProperty("TasksNotifyMode")]
        public string TasksNotifyMode{ get; set; }

        /// <summary>
        /// <p>Source context. This is used to pass user request information. The task status change callback returns the value of this field. The maximum length is 1000 characters.</p>
        /// </summary>
        [JsonProperty("SessionContext")]
        public string SessionContext{ get; set; }

        /// <summary>
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past three days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Reserved field, used for special purposes.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// <p>Valid when FileID is empty. Pull the Url to generate a new media asset and a new FileID. Media processing products will be affiliated products of the new media asset.</p><p>Note: Storage fees will occur for the new media asset.</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>The media processing transcoding result is output as standalone media assets. Enabling this option will output the product as standalone media assets and generate a brand new FileID. Currently, only TranscodeTask transcoding task output is supported as standalone media assets.</p><p>Enumeration values:</p><ul><li>ON: enable</li><li>OFF: disable</li></ul><p>Default value: OFF</p><p>Note: New media assets will incur storage fees. This option does not currently support enabling for video opening/closing credits, traceable watermarks, and other features in transcoding tasks.</p>
        /// </summary>
        [JsonProperty("OutputAsIndependentMedia")]
        public string OutputAsIndependentMedia{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamObj(map, prefix + "MediaProcessTask.", this.MediaProcessTask);
            this.SetParamObj(map, prefix + "AiContentReviewTask.", this.AiContentReviewTask);
            this.SetParamObj(map, prefix + "AiAnalysisTask.", this.AiAnalysisTask);
            this.SetParamObj(map, prefix + "AiRecognitionTask.", this.AiRecognitionTask);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "TasksNotifyMode", this.TasksNotifyMode);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "OutputAsIndependentMedia", this.OutputAsIndependentMedia);
        }
    }
}

