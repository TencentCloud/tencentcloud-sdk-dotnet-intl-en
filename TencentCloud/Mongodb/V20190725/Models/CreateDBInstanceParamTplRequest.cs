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

    public class CreateDBInstanceParamTplRequest : AbstractModel
    {
        
        /// <summary>
        /// Parameter template name.
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

        /// <summary>
        /// Template version number. This field is required when **MirrorTplId** is empty. For the purchasable versions supported by the parameter template, use the interface [DescribeSpecInfo](https://www.tencentcloud.com/document/product/240/35767?from_cn_redirect=1).
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
        public string MongoVersion{ get; set; }

        /// <summary>
        /// Instance type. This parameter is required when MirrorTplId is empty.
        /// - REPLSET: replica set instance.
        /// - SHARD: shard instance.
        /// -STANDALONE: Single-node instance.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Template description information.
        /// </summary>
        [JsonProperty("TplDesc")]
        public string TplDesc{ get; set; }

        /// <summary>
        /// Template parameter. If this parameter is not configured, the system default template is used as the version parameter.
        /// </summary>
        [JsonProperty("Params")]
        public ParamType[] Params{ get; set; }

        /// <summary>
        /// Image template ID. If an image template is specified, a new template is cloned from this template.
        /// **Note**: When MirrorTplId is not empty, MongoVersion and ClusterType will follow the template version and instance type of MirrorTpl.
        /// </summary>
        [JsonProperty("MirrorTplId")]
        public string MirrorTplId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "TplDesc", this.TplDesc);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamSimple(map, prefix + "MirrorTplId", this.MirrorTplId);
        }
    }
}

