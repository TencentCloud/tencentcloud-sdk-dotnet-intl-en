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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SwitchDBInstanceMasterSlaveRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the replica server to switched to. Valid values: `first` (the first replica server), `second` (the second replica server). Default value: `first`. `second` is valid only for a multi-AZ instance.
        /// </summary>
        [JsonProperty("DstSlave")]
        public string DstSlave{ get; set; }

        /// <summary>
        /// Whether to force the switch. Valid values: `True`, `False` (default). If this parameter is set to `True`, instance data may be lost during the switch.
        /// </summary>
        [JsonProperty("ForceSwitch")]
        public bool? ForceSwitch{ get; set; }

        /// <summary>
        /// Whether to perform the switch during a time window. Valid values: `True`, `False` (default). If `ForceSwitch` is set to `True`, this parameter is invalid.
        /// </summary>
        [JsonProperty("WaitSwitch")]
        public bool? WaitSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DstSlave", this.DstSlave);
            this.SetParamSimple(map, prefix + "ForceSwitch", this.ForceSwitch);
            this.SetParamSimple(map, prefix + "WaitSwitch", this.WaitSwitch);
        }
    }
}

