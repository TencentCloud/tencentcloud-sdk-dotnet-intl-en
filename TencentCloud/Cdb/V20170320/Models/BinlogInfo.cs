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

    public class BinlogInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>binlog backup file name</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Backup file size, unit: Byte</p>
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// <p>File storage time. Time format: 2016-03-17 02:10:37</p>
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// <p>Download link<br>Description: This download link is the same as the download address of the parameter InternetUrl.</p>
        /// </summary>
        [JsonProperty("IntranetUrl")]
        public string IntranetUrl{ get; set; }

        /// <summary>
        /// <p>Download address<br>Description: This download address is the same as the IntranetUrl download address.</p>
        /// </summary>
        [JsonProperty("InternetUrl")]
        public string InternetUrl{ get; set; }

        /// <summary>
        /// <p>Log specific type. Possible values: binlog - binary log</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>binlog file start time</p>
        /// </summary>
        [JsonProperty("BinlogStartTime")]
        public string BinlogStartTime{ get; set; }

        /// <summary>
        /// <p>binlog file expiration time</p>
        /// </summary>
        [JsonProperty("BinlogFinishTime")]
        public string BinlogFinishTime{ get; set; }

        /// <summary>
        /// <p>Region where local binlog files are located</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Backup task status. Possible values: "SUCCESS": backup successful, "FAILED": backup FAILED, "RUNNING": backup in progress.</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Detailed information of binlog offsite backup</p>
        /// </summary>
        [JsonProperty("RemoteInfo")]
        public RemoteBackupInfo[] RemoteInfo{ get; set; }

        /// <summary>
        /// <p>Storage method: 0 - regular storage, 1 - archive storage, 2 - standard storage, defaults to 0.</p>
        /// </summary>
        [JsonProperty("CosStorageType")]
        public long? CosStorageType{ get; set; }

        /// <summary>
        /// <p>Instance ID, in the format such as cdb-c1nl9rpv. This matches the instance ID displayed on the TencentDB console.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        [System.Obsolete]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Backup completion progress</p>
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "IntranetUrl", this.IntranetUrl);
            this.SetParamSimple(map, prefix + "InternetUrl", this.InternetUrl);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "BinlogStartTime", this.BinlogStartTime);
            this.SetParamSimple(map, prefix + "BinlogFinishTime", this.BinlogFinishTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "RemoteInfo.", this.RemoteInfo);
            this.SetParamSimple(map, prefix + "CosStorageType", this.CosStorageType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
        }
    }
}

