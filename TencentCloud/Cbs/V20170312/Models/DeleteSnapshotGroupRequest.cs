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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteSnapshotGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the snapshot group ID.
        /// </summary>
        [JsonProperty("SnapshotGroupId")]
        public string SnapshotGroupId{ get; set; }

        /// <summary>
        /// List of snapshot group ids. this parameter and the snapshot group ID must provide at least one. if both are provided, they will be merged with the snapshot group ID.
        /// </summary>
        [JsonProperty("SnapshotGroupIds")]
        public string[] SnapshotGroupIds{ get; set; }

        /// <summary>
        /// Specifies whether to delete the image associated with the snapshot group at the same time. valid values: set to false (not delete the image bound to the snapshot group; at this point, if the snapshot group has bound images, deletion will fail) or set to true (delete the image bound to the snapshot group simultaneously). default value is false.
        /// </summary>
        [JsonProperty("DeleteBindImages")]
        public bool? DeleteBindImages{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotGroupId", this.SnapshotGroupId);
            this.SetParamArraySimple(map, prefix + "SnapshotGroupIds.", this.SnapshotGroupIds);
            this.SetParamSimple(map, prefix + "DeleteBindImages", this.DeleteBindImages);
        }
    }
}

