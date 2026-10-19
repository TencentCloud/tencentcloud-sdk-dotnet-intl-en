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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PutEvaluationsRequest : AbstractModel
    {
        
        /// <summary>
        /// Callback token. Get the value of the ResultToken parameter from the input parameters of the selected scf cloud function in the custom rule.
        /// <a href="https://www.tencentcloud.com/document/product/583/9210?from_cn_redirect=1#.E5.87.BD.E6.95.B0.E5.85.A5.E5.8F.82.3Ca-id.3D.22input.22.3E.3C.2Fa.3E" target="_blank">SCF input parameters</a>
        /// </summary>
        [JsonProperty("ResultToken")]
        public string ResultToken{ get; set; }

        /// <summary>
        /// Custom rule evaluation result information.
        /// </summary>
        [JsonProperty("Evaluations")]
        public Evaluation[] Evaluations{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultToken", this.ResultToken);
            this.SetParamArrayObj(map, prefix + "Evaluations.", this.Evaluations);
        }
    }
}

