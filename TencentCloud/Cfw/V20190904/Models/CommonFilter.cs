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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonFilter : AbstractModel
    {
        
        /// <summary>
        /// Search key.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Enumeration type, representing the matching relationship between Name and Values.
        /// enum FilterOperatorType {
        /// equal
        ///     FILTER_OPERATOR_TYPE_EQUAL = 1;
        /// Above
        ///     FILTER_OPERATOR_TYPE_GREATER = 2;
        /// less than
        ///     FILTER_OPERATOR_TYPE_LESS = 3;
        /// >=
        ///     FILTER_OPERATOR_TYPE_GREATER_EQ = 4;
        /// <=
        ///     FILTER_OPERATOR_TYPE_LESS_EQ = 5;
        /// neq
        ///     FILTER_OPERATOR_TYPE_NO_EQ = 6;
        ///     //not in
        ///     FILTER_OPERATOR_TYPE_NOT_IN = 8;
        /// Fuzzy matching
        ///     FILTER_OPERATOR_TYPE_FUZZINESS = 9;
        /// }
        /// </summary>
        [JsonProperty("OperatorType")]
        public long? OperatorType{ get; set; }

        /// <summary>
        /// Search values, with an OR relationship between each search value.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "OperatorType", this.OperatorType);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
        }
    }
}

