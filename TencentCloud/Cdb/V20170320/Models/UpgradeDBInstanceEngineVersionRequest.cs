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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeDBInstanceEngineVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID, in the format such as cdb-c1nl9rpv or cdbro-c1nl9rpv. This matches the instance ID displayed on the TencentDB console. You can obtain it through the <a href="https://www.tencentcloud.com/document/api/236/15872?from_cn_redirect=1">Query Instance List</a> API, with its value being the InstanceId field in the output parameter.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Database engine version of the primary instance. Supported values include 5.6, 5.7, 8.0.<br>Description: Cross-version upgrade is not supported. Downgrade is not supported after upgrade.</p>
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// <p>The way to switch to a new instance defaults to 0. Supported values include: 0 - switch immediately, 1 - switch in a time window. When the value is 1, during the upgrade process, the switchover to a new instance will be performed in the time window, or the user can proactively call the API <a href="https://www.tencentcloud.com/document/product/236/15864?from_cn_redirect=1">switch to a new instance</a> to trigger the process.</p>
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public long? WaitSwitch{ get; set; }

        /// <summary>
        /// <p>Whether to upgrade the kernel subversion. Supported values: 1 - upgrade kernel subversion; 0 - upgrade database engine version. No default value. Specify the version type to upgrade.</p>
        /// </summary>
        [JsonProperty("UpgradeSubversion")]
        public long? UpgradeSubversion{ get; set; }

        /// <summary>
        /// <p>Delay threshold. Value ranges from 1 to 10. No default value. When not specified, the delay threshold is 0, which means the delay threshold is not set.</p>
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public long? MaxDelayTime{ get; set; }

        /// <summary>
        /// <p>Whether to ignore keyword errors when upgrading from 5.7 to 8.0. The value ranges from 0 to 1. 1 means ignored, 0 means not ignored. No default value. Not specified means no action taken.</p>
        /// </summary>
        [JsonProperty("IgnoreErrKeyword")]
        public long? IgnoreErrKeyword{ get; set; }

        /// <summary>
        /// <p>Upgrade support for specified parameters</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public UpgradeEngineVersionParams[] ParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
            this.SetParamSimple(map, prefix + "UpgradeSubversion", this.UpgradeSubversion);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
            this.SetParamSimple(map, prefix + "IgnoreErrKeyword", this.IgnoreErrKeyword);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
        }
    }
}

