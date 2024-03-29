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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoScalingGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group name, which can only contain letters, numbers, underscores, hyphens ("-"), and decimal points with a maximum length of 55 bytes and must be unique under your account.
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Maximum number of instances. Value range: 0-2,000.
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// Minimum number of instances. Value range: 0-2,000.
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// VPC ID; if on a basic network, enter an empty string
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Default cooldown period in seconds. Default value: 300
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public ulong? DefaultCooldown{ get; set; }

        /// <summary>
        /// Desired number of instances. The number should be no larger than the maximum and no smaller than minimum number of instances
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public ulong? DesiredCapacity{ get; set; }

        /// <summary>
        /// List of classic CLB IDs. Currently, the maximum length is 20. You cannot specify LoadBalancerIds and ForwardLoadBalancers at the same time.
        /// </summary>
        [JsonProperty("LoadBalancerIds")]
        public string[] LoadBalancerIds{ get; set; }

        /// <summary>
        /// Project ID of an instance in a scaling group. The default project is used if it’s left blank.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// List of application CLBs. Up to 100 CLBs are allowed. `LoadBalancerIds` and `ForwardLoadBalancers` cannot be specified at the same time.
        /// </summary>
        [JsonProperty("ForwardLoadBalancers")]
        public ForwardLoadBalancer[] ForwardLoadBalancers{ get; set; }

        /// <summary>
        /// List of subnet IDs. A subnet must be specified in the VPC scenario. If multiple subnets are entered, their priority will be determined by the order in which they are entered, and they will be tried one by one until instances can be successfully created.
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// Termination policy. Currently, the maximum length is 1. Value range: OLDEST_INSTANCE, NEWEST_INSTANCE. Default value: OLDEST_INSTANCE.
        /// <br><li> OLDEST_INSTANCE: The oldest instance in the auto scaling group will be terminated first.
        /// <br><li> NEWEST_INSTANCE: The newest instance in the auto scaling group will be terminated first.
        /// </summary>
        [JsonProperty("TerminationPolicies")]
        public string[] TerminationPolicies{ get; set; }

        /// <summary>
        /// List of availability zones. An availability zone must be specified in the basic network scenario. If multiple availability zones are entered, their priority will be determined by the order in which they are entered, and they will be tried one by one until instances can be successfully created.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// Retry policy. Valid values: `IMMEDIATE_RETRY` (default), `INCREMENTAL_INTERVALS`, `NO_RETRY`. A partially successful scaling is judged as a failed one.
        /// <br><li>`IMMEDIATE_RETRY`: Retry immediately. Stop retrying after five consecutive failures.
        /// <br><li>`INCREMENTAL_INTERVALS`: Retry at incremental intervals. As the number of consecutive failures increases, the retry interval gradually increases, ranging from seconds to one day.
        /// <br><li>`NO_RETRY`: Do not retry. Actions are taken when the next call or alarm message comes.
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// Availability zone verification policy. Value range: ALL, ANY. Default value: ANY.
        /// <br><li> ALL: The verification will succeed only if all availability zones (Zone) or subnets (SubnetId) are available; otherwise, an error will be reported.
        /// <br><li> ANY: The verification will success if any availability zone (Zone) or subnet (SubnetId) is available; otherwise, an error will be reported.
        /// 
        /// Common reasons why an availability zone or subnet is unavailable include stock-out of CVM instances or CBS cloud disks in the availability zone, insufficient quota in the availability zone, or insufficient IPs in the subnet.
        /// If an availability zone or subnet in Zones/SubnetIds does not exist, a verification error will be reported regardless of the value of ZonesCheckPolicy.
        /// </summary>
        [JsonProperty("ZonesCheckPolicy")]
        public string ZonesCheckPolicy{ get; set; }

        /// <summary>
        /// List of tag descriptions. In this parameter, you can specify the tags to be bound with a scaling group as well as corresponding resource instances. Each scaling group can have up to 30 tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Service settings such as unhealthy instance replacement.
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// The number of IPv6 addresses that an instance has. Valid values: 0 and 1. Default value: 0.
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// Multi-availability zone/subnet policy. Valid values: PRIORITY and EQUALITY. Default value: PRIORITY.
        /// <br><li> PRIORITY: when creating instances, choose the availability zone/subnet based on the order in the list from top to bottom. If the first instance is successfully created in the availability zone/subnet of the highest priority, all instances will be created in this availability zone/subnet.
        /// <br><li>EQUALITY: instances created for scale-out are distributed to multiple availability zones/subnets, so as to keep the number of instances in different availability zone/subnet in balance.
        /// 
        /// Notes: 
        /// <br><li> When the scaling group is based on the classic network, this policy applies to multiple availability zones. When the scaling group is based on a VPC, this policy applies to multiple subnets, and you do not need to consider availability zones. For example, if you have four subnets (A, B, C, and D) and A, B, and C are in availability zone 1 and D is in availability zone 2, you only need to decide the order of the four subnets, without worrying about the issue of availability zones.
        /// <br><li> This policy is applicable to multiple availability zones/subnets, but is not applicable to multiple models with launch configurations. Specify the models according to the model priority.
        /// <br><li> When creating instances based on the PRIORITY policy, apply the multi-model policy and then apply the multi-availability zones/subnet policy. For example, if you have models A and B and subnets 1, 2, and 3, creation will be attempted in the following order: A1, A2, A3, B1, B2, and B3. If A1 is sold out, A2 (not B1) is tried next.
        /// </summary>
        [JsonProperty("MultiZoneSubnetPolicy")]
        public string MultiZoneSubnetPolicy{ get; set; }

        /// <summary>
        /// Health check type of instances in a scaling group.<br><li>CVM: confirm whether an instance is healthy based on the network status. If the pinged instance is unreachable, the instance will be considered unhealthy. For more information, see [Instance Health Check](https://intl.cloud.tencent.com/document/product/377/8553?from_cn_redirect=1)<br><li>CLB: confirm whether an instance is healthy based on the CLB health check status. For more information, see [Health Check Overview](https://intl.cloud.tencent.com/document/product/214/6097?from_cn_redirect=1).<br>If the parameter is set to `CLB`, the scaling group will check both the network status and the CLB health check status. If the network check indicates unhealthy, the `HealthStatus` field will return `UNHEALTHY`. If the CLB health check indicates unhealthy, the `HealthStatus` field will return `CLB_UNHEALTHY`. If both checks indicate unhealthy, the `HealthStatus` field will return `UNHEALTHY|CLB_UNHEALTHY`. Default value: `CLB`.
        /// </summary>
        [JsonProperty("HealthCheckType")]
        public string HealthCheckType{ get; set; }

        /// <summary>
        /// Grace period of the CLB health check during which the `IN_SERVICE` instances added will not be marked as `CLB_UNHEALTHY`.<br>Valid range: 0-7200, in seconds. Default value: `0`.
        /// </summary>
        [JsonProperty("LoadBalancerHealthCheckGracePeriod")]
        public ulong? LoadBalancerHealthCheckGracePeriod{ get; set; }

        /// <summary>
        /// Specifies how to assign instances. Valid values: `LAUNCH_CONFIGURATION` and `SPOT_MIXED`; default value: `LAUNCH_CONFIGURATION`.
        /// <br><li>`LAUNCH_CONFIGURATION`: the launch configuration mode.
        /// <br><li>`SPOT_MIXED`: a mixed instance mode. Currently, this mode is supported only when the launch configuration takes the pay-as-you-go billing mode. With this mode, the scaling group can provision a combination of pay-as-you-go instances and spot instances to meet the configured capacity. Note that the billing mode of the associated launch configuration cannot be modified when this mode is used.
        /// </summary>
        [JsonProperty("InstanceAllocationPolicy")]
        public string InstanceAllocationPolicy{ get; set; }

        /// <summary>
        /// Specifies how to assign pay-as-you-go instances and spot instances.
        /// This parameter is valid only when `InstanceAllocationPolicy ` is set to `SPOT_MIXED`.
        /// </summary>
        [JsonProperty("SpotMixedAllocationPolicy")]
        public SpotMixedAllocationPolicy SpotMixedAllocationPolicy{ get; set; }

        /// <summary>
        /// Indicates whether the capacity re-balancing feature is enabled. This parameter is only valid for spot instances in the scaling group. Valid values:
        /// <br><li>`TRUE`: yes. Before the spot instances in the scaling group are about to be automatically repossessed, AS will terminate them. The scale-in hook (if configured) will take effect before the termination. After the termination process starts, AS will asynchronously initiate a scaling activity to meet the desired capacity.
        /// <br><li>`FALSE`: no. In this case, AS will add instances to meet the desired capacity only after the spot instances are terminated.
        /// 
        /// Default value: `False`.
        /// </summary>
        [JsonProperty("CapacityRebalance")]
        public bool? CapacityRebalance{ get; set; }

        /// <summary>
        /// Instance name sequencing settings. If this parameter is not specified, the default is not enabled. When enabled, an incremental numeric sequence will be appended to the names of instances automatically created within the scaling group.
        /// </summary>
        [JsonProperty("InstanceNameIndexSettings")]
        public InstanceNameIndexSettings InstanceNameIndexSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIds.", this.LoadBalancerIds);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancers.", this.ForwardLoadBalancers);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "TerminationPolicies.", this.TerminationPolicies);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "ZonesCheckPolicy", this.ZonesCheckPolicy);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "ServiceSettings.", this.ServiceSettings);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
            this.SetParamSimple(map, prefix + "MultiZoneSubnetPolicy", this.MultiZoneSubnetPolicy);
            this.SetParamSimple(map, prefix + "HealthCheckType", this.HealthCheckType);
            this.SetParamSimple(map, prefix + "LoadBalancerHealthCheckGracePeriod", this.LoadBalancerHealthCheckGracePeriod);
            this.SetParamSimple(map, prefix + "InstanceAllocationPolicy", this.InstanceAllocationPolicy);
            this.SetParamObj(map, prefix + "SpotMixedAllocationPolicy.", this.SpotMixedAllocationPolicy);
            this.SetParamSimple(map, prefix + "CapacityRebalance", this.CapacityRebalance);
            this.SetParamObj(map, prefix + "InstanceNameIndexSettings.", this.InstanceNameIndexSettings);
        }
    }
}

