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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceProfile : AbstractModel
    {
        
        /// <summary>
        /// Client device type. valid values: <li>iOS;</li> <li>Android;</li> <li>WebView.</li>.
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType{ get; set; }

        /// <summary>
        /// The minimum value to determine a request as high-risk ranges from 1–99. the larger the value, the higher the request risk, and the closer it resembles a request initiated by a Bot client. the default value is 50, corresponding to high-risk for values 51–100.
        /// </summary>
        [JsonProperty("HighRiskMinScore")]
        public ulong? HighRiskMinScore{ get; set; }

        /// <summary>
        /// Handling method for high-risk requests. valid values for SecurityAction Name: <li>Deny: block;</li> <li>Monitor: observation;</li> <li>Redirect: redirection;</li> <li>Challenge: Challenge.</li> default value: Monitor.
        /// </summary>
        [JsonProperty("HighRiskRequestAction")]
        public SecurityAction HighRiskRequestAction{ get; set; }

        /// <summary>
        /// Specifies the minimum value to determine a request as medium-risk. value range: 1–99. the larger the value, the higher the request risk, resembling requests initiated by a Bot client. default value: 15, corresponding to medium-risk for values 16–50.
        /// </summary>
        [JsonProperty("MediumRiskMinScore")]
        public ulong? MediumRiskMinScore{ get; set; }

        /// <summary>
        /// Handling method for medium-risk requests. SecurityAction Name parameter supports: <li>Deny: block;</li> <li>Monitor: observe;</li> <li>Redirect: Redirect;</li> <li>Challenge: Challenge.</li> default value is Monitor.
        /// </summary>
        [JsonProperty("MediumRiskRequestAction")]
        public SecurityAction MediumRiskRequestAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientType", this.ClientType);
            this.SetParamSimple(map, prefix + "HighRiskMinScore", this.HighRiskMinScore);
            this.SetParamObj(map, prefix + "HighRiskRequestAction.", this.HighRiskRequestAction);
            this.SetParamSimple(map, prefix + "MediumRiskMinScore", this.MediumRiskMinScore);
            this.SetParamObj(map, prefix + "MediumRiskRequestAction.", this.MediumRiskRequestAction);
        }
    }
}

