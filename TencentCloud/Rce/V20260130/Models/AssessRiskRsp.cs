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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssessRiskRsp : AbstractModel
    {
        
        /// <summary>
        /// <p>Decision information</p>
        /// </summary>
        [JsonProperty("Decision")]
        public Decision Decision{ get; set; }

        /// <summary>
        /// <p>Risk score, a scoring result calculated based on the product services you have enabled</p>
        /// </summary>
        [JsonProperty("Score")]
        public Score Score{ get; set; }

        /// <summary>
        /// <p>Extended information</p>
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public Cust[] ExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Decision.", this.Decision);
            this.SetParamObj(map, prefix + "Score.", this.Score);
            this.SetParamArrayObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
        }
    }
}

