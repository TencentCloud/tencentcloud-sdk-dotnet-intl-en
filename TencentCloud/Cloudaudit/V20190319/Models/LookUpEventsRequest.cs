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

namespace TencentCloud.Cloudaudit.V20190319.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LookUpEventsRequest : AbstractModel
    {
        
        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// Search criteria
        /// </summary>
        [JsonProperty("LookupAttributes")]
        public LookupAttribute[] LookupAttributes{ get; set; }

        /// <summary>
        /// Maximum number of logs that can be returned
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// Credential for viewing more logs
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamArrayObj(map, prefix + "LookupAttributes.", this.LookupAttributes);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
        }
    }
}

