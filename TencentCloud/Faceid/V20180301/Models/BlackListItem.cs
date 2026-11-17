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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlackListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Blocklist entry ID, customized by the customer when creating the entry, used to trace which entry is matched.</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>Entry type. Currently only face is supported.</p>
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>Face similarity, expressed as a string with 4 decimal places, ranging from 0.0000 to 1.0000.</p>
        /// </summary>
        [JsonProperty("FaceScore")]
        public string FaceScore{ get; set; }

        /// <summary>
        /// <p>Background similarity</p>
        /// </summary>
        [JsonProperty("BackgroundScore")]
        public string BackgroundScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "FaceScore", this.FaceScore);
            this.SetParamSimple(map, prefix + "BackgroundScore", this.BackgroundScore);
        }
    }
}

