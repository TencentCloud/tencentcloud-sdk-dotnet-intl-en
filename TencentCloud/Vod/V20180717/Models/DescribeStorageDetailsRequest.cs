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
        /// <b>The VOD [subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID. If you need to access a resource in a subapplication, set this parameter to the subapplication ID; otherwise, leave it empty.
        /// You can set this parameter to 1 to query the total usage of all applications (including the primary application) as an admin.</b>
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
        /// Storage class to query. Valid values:
        /// <li>`TotalStorage`: total storage usage in classes of STANDARD, STANDARD_IA, ARCHIVE, and DEEP ARCHIVE, excluding the storage usage for data deleted in advance.</li>
        /// <li>`StandardStorage`: STANDARD</li>
        /// <li>`InfrequentStorage`: STANDARD_IA</li>
        /// <li>`ArchiveStorage`: ARCHIVE</li>
        /// <li>`DeepArchiveStorage`: DEEP ARCHIVE</li>
        /// <li>`DeletedInfrequentStorage`: STANDARD_IA data deleted in advance</li>
        /// <li>`DeletedArchiveStorage`: ARCHIVE data deleted in advance</li>
        /// <li>`DeletedDeepArchiveStorage`: DEEP ARCHIVE data deleted in advance</li>
        /// <li>`ArchiveStandardRetrieval`: ARCHIVE data retrieved using standard retrievals</li>
        /// <li>`ArchiveExpeditedRetrieval`: ARCHIVE data retrieved using expedited retrievals</li>
        /// <li>`ArchiveBulkRetrieval`: ARCHIVE data retrieved using bulk retrievals</li>
        /// <li>`DeepArchiveStandardRetrieval`: DEEP ARCHIVE data retrieved using standard retrievals</li>
        /// <li>`DeepArchiveBulkRetrieval`: DEEP ARCHIVE data retrieved using bulk retrievals</li>
        /// Default value: `TotalStorage`
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

