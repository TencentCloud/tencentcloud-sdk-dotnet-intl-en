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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteNonlocalLoginPlacesRequest : AbstractModel
    {
        
        /// <summary>
        /// Method for deleting cross-region log-in events, available values are Ids, Ip, and All. The default is Ids.
        /// </summary>
        [JsonProperty("DelType")]
        public string DelType{ get; set; }

        /// <summary>
        /// Array of cross-region log-in event IDs. Required if DelType is Ids or DelType is not filled.
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// IP of cross-region log-in event. Required if DelType is Ip.
        /// </summary>
        [JsonProperty("Ip")]
        public string[] Ip{ get; set; }

        /// <summary>
        /// Host UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DelType", this.DelType);
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamArraySimple(map, prefix + "Ip.", this.Ip);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

