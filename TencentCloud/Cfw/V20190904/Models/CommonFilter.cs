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
        /// Search values.
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// Enum of integers that represent relations between Name and Values.
        /// enum FilterOperatorType {
        ///     // Invalid
        ///     FILTER_OPERATOR_TYPE_INVALID = 0;
        ///     // Equal to
        ///     FILTER_OPERATOR_TYPE_EQUAL = 1;
        ///     // Greater than
        ///     FILTER_OPERATOR_TYPE_GREATER = 2;
        ///     // Less than
        ///     FILTER_OPERATOR_TYPE_LESS = 3;
        ///     // Greater than or equal to
        ///     FILTER_OPERATOR_TYPE_GREATER_EQ = 4;
        ///     // Less than or equal to
        ///     FILTER_OPERATOR_TYPE_LESS_EQ = 5;
        ///     // Not equal to
        ///     FILTER_OPERATOR_TYPE_NO_EQ = 6;
        ///     // In (contained in the array)
        ///     FILTER_OPERATOR_TYPE_IN = 7;
        ///     // Not in
        ///     FILTER_OPERATOR_TYPE_NOT_IN = 8;
        ///     // Fuzzily matched
        ///     FILTER_OPERATOR_TYPE_FUZZINESS = 9;
        ///     // Existing
        ///     FILTER_OPERATOR_TYPE_EXIST = 10;
        ///     // Not existing
        ///     FILTER_OPERATOR_TYPE_NOT_EXIST = 11;
        ///     // Regular
        ///     FILTER_OPERATOR_TYPE_REGULAR = 12;
        /// }
        /// </summary>
        [JsonProperty("OperatorType")]
        public long? OperatorType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "OperatorType", this.OperatorType);
        }
    }
}

