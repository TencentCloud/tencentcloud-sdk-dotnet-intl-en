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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueueQuota : AbstractModel
    {
        
        /// <summary>
        /// Specifies the maximum number of queues that can be created.
        /// </summary>
        [JsonProperty("MaxQueue")]
        public long? MaxQueue{ get; set; }

        /// <summary>
        /// Number of queues created.
        /// </summary>
        [JsonProperty("UsedQueue")]
        public long? UsedQueue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxQueue", this.MaxQueue);
            this.SetParamSimple(map, prefix + "UsedQueue", this.UsedQueue);
        }
    }
}

