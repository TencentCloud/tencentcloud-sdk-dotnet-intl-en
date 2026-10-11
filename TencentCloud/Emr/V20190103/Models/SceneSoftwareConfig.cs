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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SceneSoftwareConfig : AbstractModel
    {
        
        /// <summary>
        /// List of deployed components. Different EMR product versions (ProductVersion) have different optional component lists. For details about how to query the optional component lists for different product versions, see [Component Version](https://www.tencentcloud.com/document/product/589/20279?from_cn_redirect=1).
        /// Example values: hive and flink.
        /// </summary>
        [JsonProperty("Software")]
        public string[] Software{ get; set; }

        /// <summary>
        /// Default Hadoop-Default. For details about the scenario-based values, see [Scenario Query](https://www.tencentcloud.com/document/product/589/14624?from_cn_redirect=1):
        /// Hadoop-Kudu
        /// Hadoop-Zookeeper
        /// Hadoop-Presto
        /// Hadoop-Hbase
        /// Hadoop-Default
        /// </summary>
        [JsonProperty("SceneName")]
        public string SceneName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Software.", this.Software);
            this.SetParamSimple(map, prefix + "SceneName", this.SceneName);
        }
    }
}

