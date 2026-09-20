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
        /// Start time in ISO 8601 format. See [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time, which should be greater than the start date. Format according to the ISO 8601 standard. For details, see [ISO date format description](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#52).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Statistical time granularity. Valid values:
        /// <li>Minute: 5 minutes.</li>
        /// <li>Day: By day.</li>
        /// The granularity is determined by the time span by default. If the time span is less than or equal to 1 day, the granularity is 5 minutes. If the time span is greater than 1 day, the granularity is 1 day.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Storage type for query. Valid values:
        /// <li>TotalStorage: total stored amount, the sum of standard, infrequent, archive, and deep archive storage capacity, excluding early deletion amount.</li>
        /// <li>StandardStorage: standard storage.</li>
        /// <li>InfrequentStorage: infrequent storage.</li>
        /// <li>ArchiveStorage: archive storage.</li>
        /// <li>DeepArchiveStorage: DEEP_ARCHIVE.</li>
        /// <li>DeletedInfrequentStorage: Early deletion amount for infrequent storage.</li>
        /// <li>DeletedArchiveStorage: early deletion amount for archive.</li>
        /// <li>DeletedDeepArchiveStorage: early deletion amount for deep archive.</li>
        /// <li>ArchiveStandardRetrieval: Archive standard retrieval amount.</li>
        /// <li>ArchiveExpeditedRetrieval: Archive quick retrieval volume.</li>
        /// <li>ArchiveBulkRetrieval: Archive batch retrieval amount.</li>
        /// <li>DeepArchiveStandardRetrieval: Deep archive standard retrieval volume.</li>
        /// <li>DeepArchiveBulkRetrieval: Deep archive batch retrieval amount.</li>
        /// <li>InfrequentRetrieval: Infrequent storage retrieval volume.</li>
        /// Default value: TotalStorage.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Storage region for query. Valid values:
        /// <li>Chinese Mainland: within the Chinese mainland (excluding Hong Kong (China), Macao (China), and Taiwan (China)).</li>
        /// <li>Outside Chinese Mainland: outside the Chinese mainland.</li>
        /// Default value: Chinese Mainland.
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

