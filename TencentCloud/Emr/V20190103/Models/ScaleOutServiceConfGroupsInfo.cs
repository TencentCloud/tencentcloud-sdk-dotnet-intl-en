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

    public class ScaleOutServiceConfGroupsInfo : AbstractModel
    {
        
        /// <summary>
        /// Component version name, for example, HDFS-2.8.5.
        /// </summary>
        [JsonProperty("ServiceComponentName")]
        public string ServiceComponentName{ get; set; }

        /// <summary>
        /// Configuration group name, for example, hdfs-core-defaultGroup. If the ConfGroupName parameter is passed in, the configuration group dimension is used.
        ///                                                              If the ConfGroupName parameter is not passed in, the cluster dimension is used.
        /// </summary>
        [JsonProperty("ConfGroupName")]
        public string ConfGroupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceComponentName", this.ServiceComponentName);
            this.SetParamSimple(map, prefix + "ConfGroupName", this.ConfGroupName);
        }
    }
}

