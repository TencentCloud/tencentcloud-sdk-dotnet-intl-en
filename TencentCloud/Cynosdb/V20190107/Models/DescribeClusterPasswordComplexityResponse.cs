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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterPasswordComplexityResponse : AbstractModel
    {
        
        /// <summary>
        /// Data dictionary parameter Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidatePasswordDictionary")]
        public ParamInfo ValidatePasswordDictionary{ get; set; }

        /// <summary>
        /// The length of the password Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidatePasswordLength")]
        public ParamInfo ValidatePasswordLength{ get; set; }

        /// <summary>
        /// Number of case-sensitive characters Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidatePasswordMixedCaseCount")]
        public ParamInfo ValidatePasswordMixedCaseCount{ get; set; }

        /// <summary>
        /// Number of digits Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidatePasswordNumberCount")]
        public ParamInfo ValidatePasswordNumberCount{ get; set; }

        /// <summary>
        /// Password level Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidatePasswordPolicy")]
        public ParamInfo ValidatePasswordPolicy{ get; set; }

        /// <summary>
        /// Number of symbols Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ValidatePasswordSpecialCharCount")]
        public ParamInfo ValidatePasswordSpecialCharCount{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ValidatePasswordDictionary.", this.ValidatePasswordDictionary);
            this.SetParamObj(map, prefix + "ValidatePasswordLength.", this.ValidatePasswordLength);
            this.SetParamObj(map, prefix + "ValidatePasswordMixedCaseCount.", this.ValidatePasswordMixedCaseCount);
            this.SetParamObj(map, prefix + "ValidatePasswordNumberCount.", this.ValidatePasswordNumberCount);
            this.SetParamObj(map, prefix + "ValidatePasswordPolicy.", this.ValidatePasswordPolicy);
            this.SetParamObj(map, prefix + "ValidatePasswordSpecialCharCount.", this.ValidatePasswordSpecialCharCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

