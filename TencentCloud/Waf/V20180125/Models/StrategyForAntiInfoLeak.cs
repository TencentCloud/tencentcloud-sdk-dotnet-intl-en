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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StrategyForAntiInfoLeak : AbstractModel
    {
        
        /// <summary>
        /// Matching Criteria, returncode (Response Code), keywords (Keywords), information (Sensitive Information)
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// Logical operator, fixed value: contains
        /// </summary>
        [JsonProperty("CompareFunc")]
        public string CompareFunc{ get; set; }

        /// <summary>
        /// Matching content
        /// The following options are available when Field is set to information:
        /// idcard (ID card), phone (phone number), and bankcard (bank card).
        /// The following options are available when Field is set to returncode:
        /// 400 (status code 400), 403 (status code 403), 404 (status code 404), 4xx (other 4xx status codes), 500 (status code 500), 501 (status code 501), 502 (status code 502), 504 (status code 504), and 5xx (other 5xx status codes).
        /// When Field is set to keywords, users need to input the matching content themselves.
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "CompareFunc", this.CompareFunc);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

