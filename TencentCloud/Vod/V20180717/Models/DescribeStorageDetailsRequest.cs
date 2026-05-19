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

    public class DescribeStorageDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time. Format according to ISO 8601. For details, see the [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time, which must be greater than the start date. Format according to ISO 8601. For details, see the [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate VOD services after December 25, 2023 must fill this field with the application ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Statistical time granularity. Valid values:
        /// <li>Minute: 5 minutes.</li>
        /// <li>Day: day.</li>
        /// By default, the granularity is determined by the time span. It is 5 minutes for a duration of up to 1 day and day for over 1 day.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Storage type for query. Valid values:
        /// <li>TotalStorage: Total stored amount, sum of standard, infrequent, archive, and deep archive storage capacity, excluding early deletion amount.</li>
        /// <li>StandardStorage: Standard storage.</li>
        /// <li>InfrequentStorage: Infrequent storage.</li>
        /// <li>ArchiveStorage: Archive storage.</li>
        /// <li>DeepArchiveStorage: deep archive storage.</li>
        /// <li>DeletedInfrequentStorage: Early deletion amount of infrequent storage.</li>
        /// <li>DeletedArchiveStorage: Early deletion amount of archive.</li>
        /// <li>DeletedDeepArchiveStorage: Early deletion amount of deep archive.</li>
        /// <li>ArchiveStandardRetrieval: Standard retrieval volume of archive.</li>
        /// <li>ArchiveExpeditedRetrieval: Quick retrieval volume of archive.</li>
        /// <li>ArchiveBulkRetrieval: Archive batch retrieval amount.</li>
        /// <li>DeepArchiveStandardRetrieval: Deep archive standard retrieval.</li>
        /// <li>DeepArchiveBulkRetrieval: Deep archive batch retrieval amount.</li>
        /// <li>InfrequentRetrieval: Retrieval volume of infrequent storage.</li>
        /// Default value: TotalStorage.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Storage region for query. Valid value:
        /// <li>Chinese Mainland: within the Chinese mainland (excluding Hong Kong (China), Macao (China) and Taiwan (China)).</li>
        /// <li>Outside Chinese Mainland: outside the Chinese mainland.</li>
        /// Default value is Chinese Mainland.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

