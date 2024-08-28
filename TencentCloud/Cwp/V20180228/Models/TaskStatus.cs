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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskStatus : AbstractModel
    {
        
        /// <summary>
        /// Scanning (including initializing)
        /// </summary>
        [JsonProperty("Scanning")]
        public string Scanning{ get; set; }

        /// <summary>
        /// Scan terminated (including terminating)
        /// </summary>
        [JsonProperty("Ok")]
        public string Ok{ get; set; }

        /// <summary>
        /// Scan failed
        /// </summary>
        [JsonProperty("Fail")]
        public string Fail{ get; set; }

        /// <summary>
        /// Scan failed, with specific reason displayed: scan timeout, low client version, or client offline
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Stop")]
        public string Stop{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scanning", this.Scanning);
            this.SetParamSimple(map, prefix + "Ok", this.Ok);
            this.SetParamSimple(map, prefix + "Fail", this.Fail);
            this.SetParamSimple(map, prefix + "Stop", this.Stop);
        }
    }
}

