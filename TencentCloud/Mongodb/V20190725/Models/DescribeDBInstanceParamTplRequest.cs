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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceParamTplRequest : AbstractModel
    {
        
        /// <summary>
        /// Parameter template ID. Use the [DescribeDBInstanceParamTpl](https://www.tencentcloud.com/document/product/240/109155?from_cn_redirect=1) interface to obtain template ID.
        /// </summary>
        [JsonProperty("TplIds")]
        public string[] TplIds{ get; set; }

        /// <summary>
        /// Specifies the template name for query.
        /// </summary>
        [JsonProperty("TplNames")]
        public string[] TplNames{ get; set; }

        /// <summary>
        /// Specifies the database version number of the parameter template to query. For supported versions, use the [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/38567?from_cn_redirect=1) API.
        /// - MONGO_36_WT: Version of the MongoDB 3.6 WiredTiger storage engine.
        /// - MONGO_40_WT: Version of the MongoDB 4.0 WiredTiger storage engine.
        /// - MONGO_42_WT: Version of the MongoDB 4.2 WiredTiger storage engine.
        /// - MONGO_44_WT: Version of the MongoDB 4.4 WiredTiger storage engine.
        /// - MONGO_50_WT: Version of the MongoDB 5.0 WiredTiger storage engine.
        /// - MONGO_60_WT: version of the MongoDB 6.0 WiredTiger storage engine.
        /// - MONGO_70_WT: version of the MongoDB 7.0 WiredTiger storage engine.
        /// - MONGO_80_WT: version of the MongoDB 8.0 WiredTiger storage engine.
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string[] MongoVersion{ get; set; }

        /// <summary>
        /// Specifies the template type for query.
        /// -DEFAULT: System default template.
        /// -CUSTOMIZE: custom template.
        /// </summary>
        [JsonProperty("TplType")]
        public string TplType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TplIds.", this.TplIds);
            this.SetParamArraySimple(map, prefix + "TplNames.", this.TplNames);
            this.SetParamArraySimple(map, prefix + "MongoVersion.", this.MongoVersion);
            this.SetParamSimple(map, prefix + "TplType", this.TplType);
        }
    }
}

