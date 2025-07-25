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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScreenProtectionStatResponse : AbstractModel
    {
        
        /// <summary>
        /// File scanning status. 0: never detected, or asset payment situation; 1: detected and malicious files exist; 2: detected and isolation protection is not enabled; 3: detected and protection is enabled with no risk.
        /// Brute force crack status. 0: protection not enabled or asset payment situation; 1: protection enabled; 2: events pending to be processed exist
        /// Vulnerability scan status. 0: never detected, or 0 asset payment situation; 1: vulnerability risks exist; 2: no risk
        /// Baseline detection status. 0: never detected, or 0 asset payment situation; 1: baseline risks exist; 2: no risk
        /// </summary>
        [JsonProperty("Info")]
        public ScreenProtection[] Info{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Info.", this.Info);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

