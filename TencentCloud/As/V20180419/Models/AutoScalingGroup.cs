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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScalingGroup : AbstractModel
    {
        
        /// <summary>
        /// Auto scaling group ID
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// Auto scaling group name
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// Current status of the scaling group. Valid values:
        /// <li>NORMAL: The scaling group is normal.</li>
        /// <li>CVM_ABNORMAL: The launch configuration is abnormal.</li>
        /// <li>LB_ABNORMAL: The CLB is abnormal.</li>
        /// <li>LB_LISTENER_ABNORMAL: The CLB listener is abnormal.</li>
        /// <li>LB_LOCATION_ABNORMAL: The forwarding configuration of the CLB listener is abnormal.</li>
        /// <li>VPC_ABNORMAL: The VPC is abnormal.</li>
        /// <li>SUBNET_ABNORMAL: The VPC subnet is abnormal.</li>
        /// <li>INSUFFICIENT_BALANCE: The balance is insufficient.</li>
        /// <li>LB_BACKEND_REGION_NOT_MATCH: The region of the CLB instance backend does not match that of the AS service.</li>
        /// <li>LB_BACKEND_VPC_NOT_MATCH: The VPC of the CLB instance does not match that of the scaling group.</li>
        /// </summary>
        [JsonProperty("AutoScalingGroupStatus")]
        public string AutoScalingGroupStatus{ get; set; }

        /// <summary>
        /// Creation time in UTC format
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Default cooldown period in seconds
        /// </summary>
        [JsonProperty("DefaultCooldown")]
        public long? DefaultCooldown{ get; set; }

        /// <summary>
        /// Desired number of instances
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public long? DesiredCapacity{ get; set; }

        /// <summary>
        /// Enabled status. Value range: `ENABLED`, `DISABLED`
        /// </summary>
        [JsonProperty("EnabledStatus")]
        public string EnabledStatus{ get; set; }

        /// <summary>
        /// List of application load balancers
        /// </summary>
        [JsonProperty("ForwardLoadBalancerSet")]
        public ForwardLoadBalancer[] ForwardLoadBalancerSet{ get; set; }

        /// <summary>
        /// Number of instances
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Number of instances in `IN_SERVICE` status
        /// </summary>
        [JsonProperty("InServiceInstanceCount")]
        public long? InServiceInstanceCount{ get; set; }

        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Launch configuration name
        /// </summary>
        [JsonProperty("LaunchConfigurationName")]
        public string LaunchConfigurationName{ get; set; }

        /// <summary>
        /// List of Classic load balancer IDs
        /// </summary>
        [JsonProperty("LoadBalancerIdSet")]
        public string[] LoadBalancerIdSet{ get; set; }

        /// <summary>
        /// Maximum number of instances
        /// </summary>
        [JsonProperty("MaxSize")]
        public long? MaxSize{ get; set; }

        /// <summary>
        /// Minimum number of instances
        /// </summary>
        [JsonProperty("MinSize")]
        public long? MinSize{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// List of subnet IDs
        /// </summary>
        [JsonProperty("SubnetIdSet")]
        public string[] SubnetIdSet{ get; set; }

        /// <summary>
        /// Destruction policy. valid values are as follows:.
        /// <Li>OLDEST_INSTANCE: terminate the oldest instance in the scaling group first, default value.</li>.
        /// <Li>NEWEST_INSTANCE: terminate the newest instance in the scaling group first.</li>.
        /// </summary>
        [JsonProperty("TerminationPolicySet")]
        public string[] TerminationPolicySet{ get; set; }

        /// <summary>
        /// VPC ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// List of availability zones
        /// </summary>
        [JsonProperty("ZoneSet")]
        public string[] ZoneSet{ get; set; }

        /// <summary>
        /// Retry policy. a partially successful scaling operation is considered a failed activity. valid values are as follows:.
        /// <Li>IMMEDIATE_RETRY: default value, means retry immediately, attempting retries in rapid succession over a short period. cease further retries after a certain number of consecutive failures (5).</li>.
        /// <Li>INCREMENTAL_INTERVALS: specifies incremental interval retry. with the number of consecutive failures, the retry interval gradually increases. the first 10 retries are quick retry, and the follow-up retry interval gradually expands to 10 minutes, 30 minutes, 60 minutes, and one day.</li>.
        /// <Li>NO_RETRY: there will be no retry until another user call or Alarm information is received.</li>.
        /// </summary>
        [JsonProperty("RetryPolicy")]
        public string RetryPolicy{ get; set; }

        /// <summary>
        /// Whether the auto scaling group is performing a scaling activity. `IN_ACTIVITY` indicates yes, and `NOT_IN_ACTIVITY` indicates no.
        /// </summary>
        [JsonProperty("InActivityStatus")]
        public string InActivityStatus{ get; set; }

        /// <summary>
        /// List of auto scaling group tags
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Service settings
        /// </summary>
        [JsonProperty("ServiceSettings")]
        public ServiceSettings ServiceSettings{ get; set; }

        /// <summary>
        /// The number of IPv6 addresses that an instance has. valid values: 0 and 1. default value: 0, which means the instance does not allocate an IPv6 address. use a private network that supports ip and enable IPv6 CIDR in the subnet. for usage restrictions, see [IPv6 usage limits](https://intl.cloud.tencent.com/document/product/1142/38369?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public long? Ipv6AddressCount{ get; set; }

        /// <summary>
        /// Multi-AZ/subnet policy.
        /// <li>PRIORITY: The instances are attempted to be created taking the order of the AZ/subnet list as the priority. If the highest-priority AZ/subnet can create instances successfully, instances can always be created in that AZ/subnet.</li>
        /// <li>EQUALITY: Select the AZ/subnet with the least number of instances for scale-out. In this way, each AZ/subnet has an opportunity for scale-out. Instances produced from multiple scale-out operations will be distributed to multiple AZs/subnets.</li>
        /// </summary>
        [JsonProperty("MultiZoneSubnetPolicy")]
        public string MultiZoneSubnetPolicy{ get; set; }

        /// <summary>
        /// Scaling group instance health check type, whose valid values include:
        /// <li>CVM: Determine whether an instance is unhealthy based on its network status. An unhealthy network status is indicated by an event where instances become unreachable via PING. Detailed criteria of judgment can be found in [Instance Health Check](https://intl.cloud.tencent.com/document/product/377/8553?from_cn_redirect=1).</li>
        /// <li>CLB: Determine whether an instance is unhealthy based on the health check status of CLB. For principles behind CLB health checks, see [Health Check](https://intl.cloud.tencent.com/document/product/214/6097?from_cn_redirect=1).</li>
        /// </summary>
        [JsonProperty("HealthCheckType")]
        public string HealthCheckType{ get; set; }

        /// <summary>
        /// Grace period of the CLB health check. the scaled-out instances IN `IN_SERVICE` will not be marked as `CLB_UNHEALTHY` within the specified time range.
        /// Default value: 0. value range: [0, 7200]. measurement unit: seconds.
        /// </summary>
        [JsonProperty("LoadBalancerHealthCheckGracePeriod")]
        public ulong? LoadBalancerHealthCheckGracePeriod{ get; set; }

        /// <summary>
        /// Instance assignment policy, whose valid values include LAUNCH_CONFIGURATION and SPOT_MIXED.
        /// <li>LAUNCH_CONFIGURATION: Represent the traditional mode of assigning instances according to the launch configuration.</li>
        /// <li>SPOT_MIXED: Represent the spot mixed mode. Currently, this mode is supported only when the launch configuration is set to the pay-as-you-go billing mode. In the mixed mode, the scaling group will scale out pay-as-you-go models or spot models based on the predefined settings. When the mixed mode is used, the billing type of the associated launch configuration cannot be modified.</li>
        /// </summary>
        [JsonProperty("InstanceAllocationPolicy")]
        public string InstanceAllocationPolicy{ get; set; }

        /// <summary>
        /// Specifies how to assign pay-as-you-go instances and spot instances.
        /// A valid value will be returned only when `InstanceAllocationPolicy` is set to `SPOT_MIXED`.
        /// </summary>
        [JsonProperty("SpotMixedAllocationPolicy")]
        public SpotMixedAllocationPolicy SpotMixedAllocationPolicy{ get; set; }

        /// <summary>
        /// Capacity rebalancing feature, which is applicable only to spot instances within the scaling group. Valid values:
        /// <li>TRUE: Enable this feature. When spot instances in the scaling group are about to be automatically recycled by the spot instance service, AS proactively initiates the termination process of the spot instances. If there is a configured scale-in hook, it will be triggered before termination. After the termination process starts, AS asynchronously initiates the scale-out to reach the expected number of instances.</li>
        /// <li>FALSE: Disable this feature. AS waits for the spot instance to be terminated before scaling out to reach the number of instances expected by the scaling group.</li>
        /// </summary>
        [JsonProperty("CapacityRebalance")]
        public bool? CapacityRebalance{ get; set; }

        /// <summary>
        /// Instance name sequencing settings.
        /// </summary>
        [JsonProperty("InstanceNameIndexSettings")]
        public InstanceNameIndexSettings InstanceNameIndexSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "AutoScalingGroupStatus", this.AutoScalingGroupStatus);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "DefaultCooldown", this.DefaultCooldown);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "EnabledStatus", this.EnabledStatus);
            this.SetParamArrayObj(map, prefix + "ForwardLoadBalancerSet.", this.ForwardLoadBalancerSet);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "InServiceInstanceCount", this.InServiceInstanceCount);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "LaunchConfigurationName", this.LaunchConfigurationName);
            this.SetParamArraySimple(map, prefix + "LoadBalancerIdSet.", this.LoadBalancerIdSet);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "SubnetIdSet.", this.SubnetIdSet);
            this.SetParamArraySimple(map, prefix + "TerminationPolicySet.", this.TerminationPolicySet);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "ZoneSet.", this.ZoneSet);
            this.SetParamSimple(map, prefix + "RetryPolicy", this.RetryPolicy);
            this.SetParamSimple(map, prefix + "InActivityStatus", this.InActivityStatus);
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

