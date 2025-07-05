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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLogContextRequest : AbstractModel
    {
        
        /// <summary>
        /// Log topic ID to be queried
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Log time in the format of YYYY-mm-dd HH:MM:SS.FFF
        /// </summary>
        [JsonProperty("BTime")]
        public string BTime{ get; set; }

        /// <summary>
        /// Log package sequence number. PkgId in the Results structure of the returned information of SearchLog API.
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// Sequence number of a log within the log package.
        /// The PkgLogId in the Results structure of the SearchLog API returned information.
        /// </summary>
        [JsonProperty("PkgLogId")]
        public long? PkgLogId{ get; set; }

        /// <summary>
        /// The previous ${PrevLogs} logs. Default value: 10.
        /// </summary>
        [JsonProperty("PrevLogs")]
        public long? PrevLogs{ get; set; }

        /// <summary>
        /// The next ${NextLogs} logs. Default value: 10.
        /// </summary>
        [JsonProperty("NextLogs")]
        public long? NextLogs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "BTime", this.BTime);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "PkgLogId", this.PkgLogId);
            this.SetParamSimple(map, prefix + "PrevLogs", this.PrevLogs);
            this.SetParamSimple(map, prefix + "NextLogs", this.NextLogs);
        }
    }
}

