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

namespace TencentCloud.Bi.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditCorpTagRequest : AbstractModel
    {
        
        /// <summary>
        /// tag ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Tag name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Import tag mode (manual/auto)
        /// </summary>
        [JsonProperty("ImportType")]
        public string ImportType{ get; set; }

        /// <summary>
        /// id of the tag table for automatic import
        /// </summary>
        [JsonProperty("AutoImportTagTableId")]
        public long? AutoImportTagTableId{ get; set; }

        /// <summary>
        /// Automatic import of associated tag fields
        /// </summary>
        [JsonProperty("AutoImportField")]
        public string AutoImportField{ get; set; }

        /// <summary>
        /// Whether it is an async request.
        /// </summary>
        [JsonProperty("AsyncRequest")]
        public bool? AsyncRequest{ get; set; }

        /// <summary>
        /// Name of the tag table for automatic import
        /// </summary>
        [JsonProperty("AutoImportTagTableName")]
        public string AutoImportTagTableName{ get; set; }

        /// <summary>
        /// Transaction ID.
        /// </summary>
        [JsonProperty("TranId")]
        public string TranId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImportType", this.ImportType);
            this.SetParamSimple(map, prefix + "AutoImportTagTableId", this.AutoImportTagTableId);
            this.SetParamSimple(map, prefix + "AutoImportField", this.AutoImportField);
            this.SetParamSimple(map, prefix + "AsyncRequest", this.AsyncRequest);
            this.SetParamSimple(map, prefix + "AutoImportTagTableName", this.AutoImportTagTableName);
            this.SetParamSimple(map, prefix + "TranId", this.TranId);
        }
    }
}

