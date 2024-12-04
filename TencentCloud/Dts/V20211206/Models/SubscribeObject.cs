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

    public class SubscribeObject : AbstractModel
    {
        
        /// <summary>
        /// Subscription data type. Valid values: database; table (if DatabaseType is mongodb, it means a collection).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectType")]
        public string ObjectType{ get; set; }

        /// <summary>
        /// Subscribed database name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Database")]
        public string Database{ get; set; }

        /// <summary>
        /// Name of the table in the subscribed database. If DatabaseType is mongodb, fill in the collection name. MongoDB only supports subscribing to a single database or a single collection.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tables")]
        public string[] Tables{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
            this.SetParamSimple(map, prefix + "Database", this.Database);
            this.SetParamArraySimple(map, prefix + "Tables.", this.Tables);
        }
    }
}

