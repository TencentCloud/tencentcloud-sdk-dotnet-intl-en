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
        /// Start time in ISO 8601 format. For more information, please see [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?lang=en&pg=).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time in ISO 8601 format, which should be larger than the start time. For more information, please see [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?lang=en&pg=).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Time granularity. Valid values:
        /// <li>Minute: 5-minute granularity</li>
        /// <li>Day: 1-day granularity</li>
        /// The value is set according to query period length by default. 5-minute granularity is set for periods no longer than 1 day, and 1-day granularity is set for periods longer than 1 day.
        /// </summary>
        [JsonProperty("Interval")]
        public string Interval{ get; set; }

        /// <summary>
        /// Queryed storage type, valid values:
        /// <li>TotalStorage: total storage amount, the sum of standard, low-frequency, archive and deep archive storage amounts, excluding early deletion amount. </li>
        /// <li>StandardStorage: Standard storage. </li>
        /// <li>InfrequentStorage: low-frequency storage. </li>
        /// <li>ArchiveStorage: archive storage. </li>
        /// <li>DeepArchiveStorage: deep archive storage. </li>
        /// <li>DeletedInfrequentStorage: The amount of early deletion of low-frequency storage. </li>
        /// <li>DeletedArchiveStorage: The amount of archives deleted in advance. </li>
        /// <li>DeletedDeepArchiveStorage: The amount of deep archive deletion in advance. 
        /// <li>ArchiveStandardRetrieval: Archive standard retrieval amount. </li>
        /// <li>ArchiveExpeditedRetrieval: archive quick retrieval amount. </li>
        /// <li>ArchiveBulkRetrieval: Archive batch retrieval amount. </li>
        /// <li>DeepArchiveStandardRetrieval: Deep archive standard retrieval amount. </li>
        /// <li>DeepArchiveBulkRetrieval: Deep archive batch retrieval amount. </li>
        /// <li>InfrequentRetrieval: Low-frequency storage retrieval amount. </li>
        /// The default value is TotalStorage.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// Storage region to query. Valid values:
        /// <li>Chinese Mainland</li>
        /// <li>Outside Chinese Mainland</li>
        /// Default value: Chinese Mainland
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

