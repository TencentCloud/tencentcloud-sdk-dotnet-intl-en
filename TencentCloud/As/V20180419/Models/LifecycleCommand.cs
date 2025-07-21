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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecycleCommand : AbstractModel
    {
        
        /// <summary>
        /// Remote command ID. this item is required if you select to execute command.
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// Custom parameter. field type is json encoded string, for example: {"varA": "222"}.
        /// key specifies the custom parameter name, and value specifies the default. both are string type.
        /// If the parameter value is not provided, the DefaultParameters of Command will be used to replace it.
        /// Custom parameters support a maximum of 20 entries. the custom parameter name must meet the following standard: number of characters has a cap of 64, value range [a-zA-Z0-9-_].
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
        }
    }
}

