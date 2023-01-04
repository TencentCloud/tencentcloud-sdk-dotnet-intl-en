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

    public class DescribeRemoteBackupConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// Remote backup retention period in days
        /// </summary>
        [JsonProperty("ExpireDays")]
        public long? ExpireDays{ get; set; }

        /// <summary>
        /// Remote data backup. Valid values:`off` (disable), `on` (enable).
        /// </summary>
        [JsonProperty("RemoteBackupSave")]
        public string RemoteBackupSave{ get; set; }

        /// <summary>
        /// Remote log backup. Valid values: `off` (disable), `on` (enable). Only when the parameter `RemoteBackupSave` is `on`, the `RemoteBinlogSave` parameter can be set to `on`.
        /// </summary>
        [JsonProperty("RemoteBinlogSave")]
        public string RemoteBinlogSave{ get; set; }

        /// <summary>
        /// List of configured remote backup regions
        /// </summary>
        [JsonProperty("RemoteRegion")]
        public string[] RemoteRegion{ get; set; }

        /// <summary>
        /// List of remote backup regions
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExpireDays", this.ExpireDays);
            this.SetParamSimple(map, prefix + "RemoteBackupSave", this.RemoteBackupSave);
            this.SetParamSimple(map, prefix + "RemoteBinlogSave", this.RemoteBinlogSave);
            this.SetParamArraySimple(map, prefix + "RemoteRegion.", this.RemoteRegion);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

