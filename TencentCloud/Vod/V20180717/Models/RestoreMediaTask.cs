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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RestoreMediaTask : AbstractModel
    {
        
        /// <summary>
        /// File ID
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// Original storage class
        /// </summary>
        [JsonProperty("OriginalStorageClass")]
        public string OriginalStorageClass{ get; set; }

        /// <summary>
        /// Target storage class. For temporary retrieval, the target storage class is the same as the original.
        /// </summary>
        [JsonProperty("TargetStorageClass")]
        public string TargetStorageClass{ get; set; }

        /// <summary>
        /// Retrieval mode. Valid values:
        /// <li>Expedited</li>
        /// <li>Standard</li>
        /// <li>Bulk</li>
        /// </summary>
        [JsonProperty("RestoreTier")]
        public string RestoreTier{ get; set; }

        /// <summary>
        /// Validity period (days) for a temporary copy. `0` indicates permanent retrieval.
        /// </summary>
        [JsonProperty("RestoreDay")]
        public long? RestoreDay{ get; set; }

        /// <summary>
        /// This field has been disused.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// This field has been disused.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "OriginalStorageClass", this.OriginalStorageClass);
            this.SetParamSimple(map, prefix + "TargetStorageClass", this.TargetStorageClass);
            this.SetParamSimple(map, prefix + "RestoreTier", this.RestoreTier);
            this.SetParamSimple(map, prefix + "RestoreDay", this.RestoreDay);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

