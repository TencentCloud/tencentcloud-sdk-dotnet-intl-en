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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// Public network download address (valid for six hours). This field will be disused soon.
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string[] DownloadUrl{ get; set; }

        /// <summary>
        /// Private network download address (valid for six hours). This field will be disused soon.
        /// </summary>
        [JsonProperty("InnerDownloadUrl")]
        public string[] InnerDownloadUrl{ get; set; }

        /// <summary>
        /// Filename. This field will be disused soon.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Filenames")]
        public string[] Filenames{ get; set; }

        /// <summary>
        /// List of backup file information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupInfos")]
        public BackupDownloadInfo[] BackupInfos{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "DownloadUrl.", this.DownloadUrl);
            this.SetParamArraySimple(map, prefix + "InnerDownloadUrl.", this.InnerDownloadUrl);
            this.SetParamArraySimple(map, prefix + "Filenames.", this.Filenames);
            this.SetParamArrayObj(map, prefix + "BackupInfos.", this.BackupInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

