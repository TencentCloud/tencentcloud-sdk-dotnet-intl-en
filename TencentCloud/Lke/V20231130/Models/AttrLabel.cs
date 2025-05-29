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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttrLabel : AbstractModel
    {
        
        /// <summary>
        /// Label source.
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// Label ID.
        /// </summary>
        [JsonProperty("AttrBizId")]
        public string AttrBizId{ get; set; }

        /// <summary>
        /// Label identification.
        /// </summary>
        [JsonProperty("AttrKey")]
        public string AttrKey{ get; set; }

        /// <summary>
        /// Label name.
        /// </summary>
        [JsonProperty("AttrName")]
        public string AttrName{ get; set; }

        /// <summary>
        /// Label value.
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "AttrBizId", this.AttrBizId);
            this.SetParamSimple(map, prefix + "AttrKey", this.AttrKey);
            this.SetParamSimple(map, prefix + "AttrName", this.AttrName);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
        }
    }
}

