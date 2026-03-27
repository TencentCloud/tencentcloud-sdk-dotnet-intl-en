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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegistryConnDetectResult : AbstractModel
    {
        
        /// <summary>
        /// Host quuid or backend for Connectivity Detection
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host uuid or backend for Connectivity Detection
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Detection Result Status
        /// </summary>
        [JsonProperty("ConnDetectStatus")]
        public string ConnDetectStatus{ get; set; }

        /// <summary>
        /// Detection Result Information
        /// </summary>
        [JsonProperty("ConnDetectMessage")]
        public string ConnDetectMessage{ get; set; }

        /// <summary>
        /// Failure Resolution
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// Failure Cause
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "ConnDetectStatus", this.ConnDetectStatus);
            this.SetParamSimple(map, prefix + "ConnDetectMessage", this.ConnDetectMessage);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
        }
    }
}

