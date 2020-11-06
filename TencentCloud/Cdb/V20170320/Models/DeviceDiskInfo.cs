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

    public class DeviceDiskInfo : AbstractModel
    {
        
        /// <summary>
        /// Time percentage of IO operations per second
        /// </summary>
        [JsonProperty("IoRatioPerSec")]
        public long?[] IoRatioPerSec{ get; set; }

        /// <summary>
        /// Average wait time of device I/O operations * 100 in milliseconds. For example, if the value is 201, the average wait time of I/O operations is 201/100 = 2.1 milliseconds.
        /// </summary>
        [JsonProperty("IoWaitTime")]
        public long?[] IoWaitTime{ get; set; }

        /// <summary>
        /// Average number of read operations completed by the disk per second * 100. For example, if the value is 2,002, the average number of read operations completed by the disk per second is 2,002/100=20.2.
        /// </summary>
        [JsonProperty("Read")]
        public long?[] Read{ get; set; }

        /// <summary>
        /// Average number of write operations completed by the disk per second * 100. For example, if the value is 30,001, the average number of write operations completed by the disk per second is 30,001/100=300.01.
        /// </summary>
        [JsonProperty("Write")]
        public long?[] Write{ get; set; }

        /// <summary>
        /// Disk capacity. Each value is comprised of two data, with the first data representing the used capacity and the second one representing the total disk capacity.
        /// </summary>
        [JsonProperty("CapacityRatio")]
        public long?[] CapacityRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "IoRatioPerSec.", this.IoRatioPerSec);
            this.SetParamArraySimple(map, prefix + "IoWaitTime.", this.IoWaitTime);
            this.SetParamArraySimple(map, prefix + "Read.", this.Read);
            this.SetParamArraySimple(map, prefix + "Write.", this.Write);
            this.SetParamArraySimple(map, prefix + "CapacityRatio.", this.CapacityRatio);
        }
    }
}

