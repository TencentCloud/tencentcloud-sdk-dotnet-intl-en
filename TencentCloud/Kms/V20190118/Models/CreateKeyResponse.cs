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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateKeyResponse : AbstractModel
    {
        
        /// <summary>
        /// Globally unique CMK ID
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Alias that makes a key more recognizable and understandable
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Key creation time in UNIX timestamp format
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// CMK description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// CMK status
        /// </summary>
        [JsonProperty("KeyState")]
        public string KeyState{ get; set; }

        /// <summary>
        /// CMK usage
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// Tag operation return code. 0: success; 1: internal error; 2: business processing error
        /// </summary>
        [JsonProperty("TagCode")]
        public ulong? TagCode{ get; set; }

        /// <summary>
        /// Tag operation return information
        /// </summary>
        [JsonProperty("TagMsg")]
        public string TagMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyState", this.KeyState);
            this.SetParamSimple(map, prefix + "KeyUsage", this.KeyUsage);
            this.SetParamSimple(map, prefix + "TagCode", this.TagCode);
            this.SetParamSimple(map, prefix + "TagMsg", this.TagMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

