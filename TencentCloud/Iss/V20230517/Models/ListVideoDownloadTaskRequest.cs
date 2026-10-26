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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListVideoDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Device name. Fuzzy search supported.
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// Channel name, used for fuzzy search
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// Task status (0: preparing, 1: executing, 2: completed, 3: failure)
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Sorting rule (only StartTime is supported. A hyphen (-) indicates descending order, e.g., -StartTime)
        /// </summary>
        [JsonProperty("SortRule")]
        public string SortRule{ get; set; }

        /// <summary>
        /// Whether the response carries the preview address (0: without; 1: carry)
        /// </summary>
        [JsonProperty("WithPreviewUrl")]
        public long? WithPreviewUrl{ get; set; }

        /// <summary>
        /// Page number
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// Pagination size.
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Download task ID
        /// </summary>
        [JsonProperty("DownloadTaskId")]
        public string DownloadTaskId{ get; set; }

        /// <summary>
        /// URL expiration time (in seconds), with a maximum value of 86400 seconds (1 day).
        /// </summary>
        [JsonProperty("UrlExpires")]
        public long? UrlExpires{ get; set; }

        /// <summary>
        /// Task date. Defaults to the current day.
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SortRule", this.SortRule);
            this.SetParamSimple(map, prefix + "WithPreviewUrl", this.WithPreviewUrl);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "DownloadTaskId", this.DownloadTaskId);
            this.SetParamSimple(map, prefix + "UrlExpires", this.UrlExpires);
            this.SetParamSimple(map, prefix + "Date", this.Date);
        }
    }
}

