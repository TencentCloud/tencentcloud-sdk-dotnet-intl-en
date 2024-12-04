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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifiedSubscribeObject : AbstractModel
    {
        
        /// <summary>
        /// Subscription object type. Valid values: 0 (database); 1 (table, for mongo tasks, this corresponds to a collection).Note: mongo only supports full instance, single database or single collection subscription, so this field should not conflict with SubscribeObjectType. For example, when SubscribeObjectType=4, it means mongo single database subscription, then 0 should be passed in this field.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectsType")]
        public long? ObjectsType{ get; set; }

        /// <summary>
        /// Subscription database nameNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// Name of the table (or collection) in the subscription database. If ObjectsType is 1, this field is required and not empty; 
        /// </summary>
        [JsonProperty("TableNames")]
        public string[] TableNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectsType", this.ObjectsType);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamArraySimple(map, prefix + "TableNames.", this.TableNames);
        }
    }
}

