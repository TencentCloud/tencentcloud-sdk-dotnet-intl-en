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

    public class ProcessMediaByProcedureRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Name of the <a href="https://www.tencentcloud.com/document/product/266/33475?from_cn_redirect=1#.E4.BB.BB.E5.8A.A1.E6.B5.81">task flow</a>.</p>
        /// </summary>
        [JsonProperty("ProcedureName")]
        public string ProcedureName{ get; set; }

        /// <summary>
        /// <p>Media file ID.<br>Either FileId or MediaStoragePath must be provided.</p>
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// <p>Storage path of the media.<br>Only sub-apps in <a href="https://www.tencentcloud.com/document/product/266/126825?from_cn_redirect=1">FileID + Path mode</a> can initiate tasks through MediaStoragePath.<br>One of FileId and MediaStoragePath must be provided.</p>
        /// </summary>
        [JsonProperty("MediaStoragePath")]
        public string MediaStoragePath{ get; set; }

        /// <summary>
        /// <p><b>On-demand <a href="/document/product/266/14574">application</a> ID. For customers who activate on-demand services from December 25, 2023, this field must be filled in as the app ID when accessing resources in on-demand applications (whether the default application or a newly created application).</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

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
        /// <p>Identifier for deduplication. If a request with the same identifier has been sent within the past 7 days, an error is returned for the current request. The maximum length is 50 characters. If this is not specified or left empty, deduplication is not performed.</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>Reserved field, used for special purposes.</p>
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcedureName", this.ProcedureName);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "MediaStoragePath", this.MediaStoragePath);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TasksPriority", this.TasksPriority);
            this.SetParamSimple(map, prefix + "TasksNotifyMode", this.TasksNotifyMode);
            this.SetParamSimple(map, prefix + "SessionContext", this.SessionContext);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

