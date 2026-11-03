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

    public class UserRiskProfile : AbstractModel
    {
        
        /// <summary>
        /// <p>Minimum risk score for high-risk requests. A request is considered high-risk when its score is equal to or greater than this value.</p><p>Value range: [2, 99]</p><p>Default value: 50</p>
        /// </summary>
        [JsonProperty("HighRiskMinScore")]
        public ulong? HighRiskMinScore{ get; set; }

        /// <summary>
        /// <p>Handling method for high-risk requests. Supported values for SecurityAction Name: <li>Deny: block;</li><li>Monitor: observe;</li><li>Redirect: redirect;</li><li>Challenge: challenge.</li>Default value: Monitor</p>
        /// </summary>
        [JsonProperty("HighRiskRequestAction")]
        public SecurityAction HighRiskRequestAction{ get; set; }

        /// <summary>
        /// <p>Minimum risk score for a medium-risk request. A score equal to or greater than this value and less than HighRiskMinScore is considered medium-risk; a score lower than this value is considered low risk.</p><p>Value range: [1, 98]</p><p>Default value: 15</p>
        /// </summary>
        [JsonProperty("MediumRiskMinScore")]
        public ulong? MediumRiskMinScore{ get; set; }

        /// <summary>
        /// <p>Handling method for medium-risk requests. Supported values for the Name parameter of SecurityAction: <li>Deny: block;</li><li>Monitor: observe;</li><li>Redirect: redirect;</li><li>Challenge: challenge.</li>Default value: Monitor</p>
        /// </summary>
        [JsonProperty("MediumRiskRequestAction")]
        public SecurityAction MediumRiskRequestAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighRiskMinScore", this.HighRiskMinScore);
            this.SetParamObj(map, prefix + "HighRiskRequestAction.", this.HighRiskRequestAction);
            this.SetParamSimple(map, prefix + "MediumRiskMinScore", this.MediumRiskMinScore);
            this.SetParamObj(map, prefix + "MediumRiskRequestAction.", this.MediumRiskRequestAction);
        }
    }
}

