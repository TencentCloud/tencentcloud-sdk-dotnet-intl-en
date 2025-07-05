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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TopicRetentionTimeConfigRsp : AbstractModel
    {
        
        /// <summary>
        /// Expected value, i.e., the topic message retention time (min) configured
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Expect")]
        public long? Expect{ get; set; }

        /// <summary>
        /// Current value (min), i.e., the retention time currently in effect, which may be dynamically adjusted
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Current")]
        public long? Current{ get; set; }

        /// <summary>
        /// Last modified time
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ModTimeStamp")]
        public long? ModTimeStamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Expect", this.Expect);
            this.SetParamSimple(map, prefix + "Current", this.Current);
            this.SetParamSimple(map, prefix + "ModTimeStamp", this.ModTimeStamp);
        }
    }
}

