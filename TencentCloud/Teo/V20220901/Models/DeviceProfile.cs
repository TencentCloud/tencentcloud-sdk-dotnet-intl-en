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
        /// <p>Client device type. Valid values: <li>iOS;</li><li>Android;</li><li>WebView;</li><li>WeChatMiniProgram.</li></p>
        /// </summary>
        [JsonProperty("ClientType")]
        public string ClientType{ get; set; }

        /// <summary>
        /// <p>Minimum risk score for high-risk requests. A request is considered high-risk when its score is equal to or greater than this value.</p><p>Value range: [2, 99]</p><p>Default value: 50</p>
        /// </summary>
        [JsonProperty("HighRiskMinScore")]
        public ulong? HighRiskMinScore{ get; set; }

        /// <summary>
        /// <p>Handling method for high-risk requests. Supported values for the Name parameter of SecurityAction: <li>Deny: Block;</li><li>Monitor: Observe;</li><li>Redirect: Redirection;</li><li>Challenge: Challenge.</li>Default value: Monitor.</p>
        /// </summary>
        [JsonProperty("HighRiskRequestAction")]
        public SecurityAction HighRiskRequestAction{ get; set; }

        /// <summary>
        /// <p>The minimum risk score for a medium-risk request. When the score is equal to or greater than this value and less than HighRiskMinScore, it is determined as medium-risk. When it is below this value, it is determined as low risk.</p><p>Value range: [1, 98]</p><p>Default value: 15</p>
        /// </summary>
        [JsonProperty("MediumRiskMinScore")]
        public ulong? MediumRiskMinScore{ get; set; }

        /// <summary>
        /// <p>Handling method for medium risk requests. Supported values for the Name of SecurityAction: <li>Deny: block;</li><li>Monitor: monitor;</li><li>Redirect: redirect;</li><li>Challenge: challenge.</li>Default value: Monitor.</p>
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

