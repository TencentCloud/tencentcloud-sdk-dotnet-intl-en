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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTableGroupTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the cluster where table group tags need to be modified
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The ID of the table group whose tags need to be modified
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// The list of tags to add or modify
        /// </summary>
        [JsonProperty("ReplaceTags")]
        public TagInfoUnit[] ReplaceTags{ get; set; }

        /// <summary>
        /// Tags to delete
        /// </summary>
        [JsonProperty("DeleteTags")]
        public TagInfoUnit[] DeleteTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamArrayObj(map, prefix + "ReplaceTags.", this.ReplaceTags);
            this.SetParamArrayObj(map, prefix + "DeleteTags.", this.DeleteTags);
        }
    }
}

