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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindNumberCallInInterfaceRequest : AbstractModel
    {
        
        /// <summary>
        /// App ID (required). can be used to view https://console.cloud.tencent.com/ccc.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// Number to be bound.
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// Specifies the callback url to be bound.
        /// </summary>
        [JsonProperty("CallInInterface")]
        public Interface CallInInterface{ get; set; }

        /// <summary>
        /// Bind number type. specifies the type of the bind number. inner: internal number | number: line number.
        /// </summary>
        [JsonProperty("NumberType")]
        public string NumberType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamObj(map, prefix + "CallInInterface.", this.CallInInterface);
            this.SetParamSimple(map, prefix + "NumberType", this.NumberType);
        }
    }
}

