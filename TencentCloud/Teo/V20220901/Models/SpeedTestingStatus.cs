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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpeedTestingStatus : AbstractModel
    {
        
        /// <summary>
        /// The URL.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Whether the URL uses HTTPS.
        /// </summary>
        [JsonProperty("Tls")]
        public bool? Tls{ get; set; }

        /// <summary>
        /// Creation time of the task.
        /// </summary>
        [JsonProperty("CreatedOn")]
        public string CreatedOn{ get; set; }

        /// <summary>
        /// The task status. Values:
        /// <li>`200`: The task completed.</li>
        /// <li>`100`: The task is running.</li>
        /// <li>`503`: The task failed./li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StatusCode")]
        public long? StatusCode{ get; set; }

        /// <summary>
        /// The user agent.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UA")]
        public string UA{ get; set; }

        /// <summary>
        /// The network environment.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Connectivity")]
        public string Connectivity{ get; set; }

        /// <summary>
        /// Whether the URL is reachable. Values:
        /// <li>`true`: Yes</li>
        /// <li>`false`: No</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Reachable")]
        public bool? Reachable{ get; set; }

        /// <summary>
        /// Whether the URL connection timed out. Values:
        /// <li>`true`: Yes</li>
        /// <li>`false`: No</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TimedOut")]
        public bool? TimedOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Tls", this.Tls);
            this.SetParamSimple(map, prefix + "CreatedOn", this.CreatedOn);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "UA", this.UA);
            this.SetParamSimple(map, prefix + "Connectivity", this.Connectivity);
            this.SetParamSimple(map, prefix + "Reachable", this.Reachable);
            this.SetParamSimple(map, prefix + "TimedOut", this.TimedOut);
        }
    }
}

